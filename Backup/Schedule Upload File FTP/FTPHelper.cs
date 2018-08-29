using System;
using System.Collections.Generic;

using System.Text;
using System.Net;
using System.IO;
using ConfigCOMPortBank;

namespace Schedule_Upload_File_FTP
{
    public class FTPHelper
    {
       
            private readonly string ftpUserName;
            private readonly string ftpPassword;
            private readonly string ftpRootPath;
            //public ILogger Logger { get; set; }

            public FTPHelper(string user, string password, string server)
            {
                this.ftpUserName = user;
                this.ftpPassword = password;
                this.ftpRootPath = server.TrimEnd('/') + "/";
            }

            public string UploadFile(string source)
            {
                CTLError.WriteError(string.Format("upload file : {0}，FTP： {1}", source, ftpRootPath), "");
                //Logger.Debug("upload file : {0}，FTP： {1}", source, ftpRootPath);
                //string fileName = GenerateFileName(source);
                string fileName = source;
                //Logger.Debug("file name： {0}", fileName);
                //CTLError.WriteError(string.Format("file name： {0}", fileName), "");
                var result = UploadFile(fileName, source);
                //Logger.Debug("Tải lên thành công! Trả lại đường dẫn tệp đến：{0}", fileName);
                //CTLError.WriteError(string.Format("Tải lên thành công! Trả lại đường dẫn tệp đến：{0}", fileName), "");
                return result.ToString();
            }

            public byte[] DownloadFile(string source)
            {
                //Logger.Debug("Đọc các tập tin trên FTP：{0}", source);
                CTLError.WriteError(string.Format("Đọc các tập tin trên FTP：{0}", source), "");
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpRootPath + source);
                req.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                req.Method = WebRequestMethods.Ftp.DownloadFile;
                req.UseBinary = true;
                try
                {
                    FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                    using (Stream ftpStream = response.GetResponseStream())
                    using (var memoryStream = new MemoryStream())
                    {
                        StreamExtensions.CopyTo(ftpStream, memoryStream);
                        //ftpStream.CopyTo(memoryStream);
                        //CopyTo(ftpStream, memoryStream);
                        response.Close();
                        req.Abort();
                        return memoryStream.ToArray();
                    }
                }
                catch (Exception e)
                {
                    //Logger.Warn("Đã xảy ra lỗi khi đọc tệp！{0}", e.Message);
                    req.Abort();
                    return null;
                }
            }
            //public Stream CopyTo(Stream input, Stream output)
            //{
            //    byte[] buffer = new byte[16 * 1024]; // Fairly arbitrary size
            //    int bytesRead;

            //    while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        output.Write(buffer, 0, bytesRead);
            //    }
            //    return out
            //}
            public bool DeleteFile(string source)
            {
                CTLError.WriteError(string.Format("Xóa các tập tin trên FTP：{0}", source), "");
                //Logger.Debug("Xóa các tập tin trên FTP：{0}", source);
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpRootPath + source);
                req.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                req.Method = WebRequestMethods.Ftp.DeleteFile;
                try
                {
                    FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                    response.Close();
                }
                catch (Exception e)
                {
                    //Logger.Warn("Đã xảy ra lỗi khi xóa tệp！{0}", e.Message);
                    CTLError.WriteError(string.Format("Đã xảy ra lỗi khi xóa tệp！"), e.Message);
                    req.Abort();
                    return false;
                }
                req.Abort();
                CTLError.WriteError(string.Format("Xóa thành công！"), "");
                //Logger.Debug("Xóa thành công！");
                return true;
            }

            #region private methods
            /// <summary>
            /// 上传文件到FTP指定目录
            /// </summary>
            /// <param name="ftpFileName">FTP指定的目录，包含文件全名</param>
            /// <param name="source"></param>
            private bool UploadFile(string ftpFileName, string source)
            {
                //CreateFtpDirectory(ftpFileName);
                FileInfo fi = new FileInfo(source);
                FileStream fs = fi.OpenRead();
                long length = fs.Length;
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpRootPath + "www.duy.somee.com/"+fi.Name);
                req.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                req.Method = WebRequestMethods.Ftp.UploadFile;
                req.ContentLength = length;
                req.Timeout = 10 * 1000;
                try
                {
                    Stream stream = req.GetRequestStream();
                    int BufferLength = 4096;
                    byte[] b = new byte[BufferLength];
                    int i;
                    while ((i = fs.Read(b, 0, BufferLength)) > 0)
                    {
                        stream.Write(b, 0, i);
                    }
                    stream.Close();
                    stream.Dispose();
                }
                catch (Exception e)
                {
                    //Logger.Error("Đã xảy ra lỗi khi tải tệp lên！", e);
                    CTLError.WriteError(string.Format("Đã xảy ra lỗi khi tải tệp lên ! "), e.Message);
                    return false;
                }
                finally
                {
                    fs.Close();
                    req.Abort();
                }
                req.Abort();
                return true;
            }

            /// <summary>
            /// 根据当前时间生成文件路径和文件名。类似：
            /// 2014/06/17/guid.png
            /// </summary>
            /// <param name="source">要上传文件的绝对路径</param>
            /// <returns></returns>
            private string GenerateFileName(string source)
            {
                var extension = Path.GetExtension(source);
                var now = DateTime.Now.ToString("yyyy/MM/dd");
                var guid = Guid.NewGuid().ToString();
                return now + "/" + guid + extension;
            }

            private void CreateFtpDirectory(string destFilePath)
            {
                string fullDir = FtpParseDirectory(destFilePath);
                string[] dirs = fullDir.Split('/');
                string curDir = "/";
                for (int i = 0; i < dirs.Length; i++)
                {
                    string dir = dirs[i];
                    if (dir != null && dir.Length > 0)
                    {
                        try
                        {
                            curDir += dir + "/";
                            if (!CheckIfDirectoryExists(curDir))
                                MakeDirectory(curDir);
                        }
                        catch (Exception e)
                        {
                            //Logger.Error("Lỗi khi tạo thư mục FTP!", e);
                            CTLError.WriteError(string.Format("Lỗi khi tạo thư mục FTP!"), e.Message);
                        }
                    }
                }
            }

            private static string FtpParseDirectory(string destFilePath)
            {
                return destFilePath.Substring(0, destFilePath.LastIndexOf("/"));
            }

            /// <summary>
            /// 检查FTP服务器上，指定的路径是否存在
            /// </summary>
            /// <param name="localFile"></param>
            /// <returns></returns>
            private bool CheckIfDirectoryExists(string localFile)
            {
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpRootPath + localFile);
                req.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                req.Method = WebRequestMethods.Ftp.ListDirectory;
                try
                {
                    FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                    response.Close();
                }
                catch (Exception e)
                {
                    //Logger.Warn("Thư mục FTP '{0}' không tồn tại! Thông báo lỗi: {1}", localFile, e.Message);
                    CTLError.WriteError(string.Format("Thư mục FTP '{0}' không tồn tại! Thông báo lỗi: {1}", localFile), e.Message);
                    req.Abort();
                    return false;
                }
                //Logger.Debug("  Có một thư mục FTP: {0}", localFile);
                req.Abort();
                return true;
            }

            /// <summary>
            /// 在FTP服务器上创建指定的目录
            /// </summary>
            /// <param name="localFile"></param>
            /// <returns></returns>
            private bool MakeDirectory(string localFile)
            {
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpRootPath + localFile);
                req.Credentials = new NetworkCredential(ftpUserName, ftpPassword);
                req.Method = WebRequestMethods.Ftp.MakeDirectory;
                try
                {
                    FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                    response.Close();
                }
                catch (Exception e)
                {
                    //Logger.Warn("Tạo thư mục FTP: '{0}' không thành công! Thông báo lỗi: {1}", localFile, e.Message);
                    CTLError.WriteError(string.Format("Tạo thư mục FTP: '{0}' không thành công! Thông báo lỗi: {1}", localFile), e.Message);
                    req.Abort();
                    return false;
                }
                //Logger.Debug("Tạo thư mục FTP: '{0}' thành công!", localFile);
                CTLError.WriteError(string.Format("Tạo thư mục FTP: '{0}' thành công!", localFile), "");
                req.Abort();
                return true;
            }
            #endregion
        }
    
}
