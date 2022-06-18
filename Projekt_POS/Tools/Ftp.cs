using FluentFTP;
using System.Net;
using System.Security;
using System.Text;

internal class Ftp
{
    
    private FtpClient _client;
    public string _serverAddress = "lockdownband.pl";
    public string _user = "konto_studia@lockdownband.pl";
    public string _password = "GW7PJZY8cS)V";



    public string PhotoAddressInfo { get; set; }
    public Ftp()
    {
        // Połączenie z serwerem FTP Mastersport'u
        if (_client == null)
        {
            _client = new FtpClient
            {
                Host = _serverAddress,
                Credentials = new NetworkCredential(_user, _password)
            };
        }
    }
    public string[] GetPhotosUrl(string path)
    {
        try
        {
            _client.Connect();
            _client.SetWorkingDirectory(path);
            var urlTab = _client.GetNameListing();
            _client.Disconnect();
            return urlTab;
        }
        catch (Exception)
        {
            return null;
        }
    }
    public void DownloadDb()
    {
        if (!File.Exists(@"..\..\..\Database\pos.db"))
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                _client.Connect();
                _client.Download(ms, "Database/pos.db", 0, progress: null);

                using (FileStream fs = new FileStream(@"..\..\..\Database\pos.db", FileMode.Create, FileAccess.Write))
                {
                    ms.WriteTo(fs);
                    ms.Dispose();
                    fs.Dispose();
                    _client.Disconnect();
                }
                _client.Disconnect();
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd");
                _client.Disconnect();
            }
        }
    }
    public FtpStatus UploadFile(string fileName)
    {
        _client.Connect();
        _client.RetryAttempts = 3;
        
        var result = _client.UploadFile(@"..\..\..\Database\pos.db", "/Database/pos.db", FtpRemoteExists.Overwrite, true, FtpVerify.Retry);
        if(result == FtpStatus.Success)
        {
            _client.Disconnect();
            File.Delete(@"..\..\..\Database\pos.db");

        }
        return result;
    }
    public FtpStatus UploadData(byte[] data)
    {
        var byteArray = data;
        _client.Connect();
        _client.UploadDataType = FtpDataType.Binary;
        _client.RetryAttempts = 3;
        var fileName = "pos.db";
        var send = _client.Upload(byteArray, "Database/pod.db", FtpRemoteExists.Overwrite, true);
        return send;
    }
    public bool ConnectionStatus()
    {
        try
        {
            _client.Connect();
            _client.Disconnect();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
