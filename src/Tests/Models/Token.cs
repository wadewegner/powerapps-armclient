namespace Tests.Models
{
    public class Token
    {
        public string TokenType { get; set; }
        public string ExpiresIn { get; set; }
        public string Scope { get; set; }
        public string ExpiresOn { get; set; }
        public string NotBefore { get; set; }
        public string Resource { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string IdToken { get; set; }
        public string ResourceUri { get; set; }
        public string TokenAcquireTime { get; set; }
        public string LoginSettingId { get; set; }
        public string ServiceEndpointUri { get; set; }
    }
}