namespace Application.Constants;

public static class MailTemplates
{
    public static class Settings
    {
        public const bool USE_HTML = true;
        public const string FONT_FAMILY = "'Segoe UI', Roboto, Arial, sans-serif";
        public const string FONT_SIZE = "15px";
        public const string PRIMARY_COLOR = "#4A6FFF";
        public const string BG_COLOR = "#f4f5f7";
        public const string TEXT_COLOR = "#333333";
    }

    public static class PasswordReset
    {
        public const string SUBJECT = "Şifre Sıfırlama Kodu";
        public static string GetBody(string code) => $@"
            <div style='font-family: {Settings.FONT_FAMILY}; font-size: {Settings.FONT_SIZE}; color: {Settings.TEXT_COLOR}; max-width: 600px; margin: 0 auto; background-color: {Settings.BG_COLOR}; padding: 20px; border-radius: 8px;'>
                <div style='background-color: white; padding: 30px; border-radius: 6px; box-shadow: 0px 2px 10px rgba(0,0,0,0.08);'>
                    <div style='text-align: center; border-bottom: 1px solid #eee; padding-bottom: 20px; margin-bottom: 20px;'>
                        <h2 style='color: {Settings.PRIMARY_COLOR}; margin-bottom: 10px; font-weight: 600;'>Şifre Sıfırlama</h2>
                    </div>
                    <p style='margin-bottom: 20px; line-height: 1.5;'>Merhaba,</p>
                    <p style='margin-bottom: 20px; line-height: 1.5;'>Hesabınız için şifre sıfırlama talebinde bulundunuz. Şifrenizi sıfırlamak için aşağıdaki kodu kullanabilirsiniz:</p>
                    <div style='background-color: #f0f4ff; padding: 15px; border-radius: 5px; text-align: center; margin: 25px 0;'>
                        <span style='font-size: 24px; font-weight: bold; letter-spacing: 5px; color: {Settings.PRIMARY_COLOR};'>{code}</span>
                    </div>
                    <p style='margin-bottom: 20px; line-height: 1.5;'>Bu kod <strong>15 dakika</strong> süreyle geçerlidir.</p>
                    <p style='margin-bottom: 10px; line-height: 1.5;'>Eğer bu talebi siz yapmadıysanız, lütfen bu e-postayı dikkate almayınız.</p>
                    <div style='margin-top: 30px; padding-top: 20px; border-top: 1px solid #eee; font-size: 13px; color: #777; text-align: center;'>
                        <p>Bu otomatik olarak oluşturulmuş bir e-postadır, lütfen yanıtlamayınız.</p>
                    </div>
                </div>
            </div>";
    }

    public static class EmailVerification
    {
        public const string SUBJECT = "Email Doğrulama Kodu";
        public static string GetBody(string code) => $@"
            <div style='font-family: {Settings.FONT_FAMILY}; font-size: {Settings.FONT_SIZE}; color: {Settings.TEXT_COLOR}; max-width: 600px; margin: 0 auto; background-color: {Settings.BG_COLOR}; padding: 20px; border-radius: 8px;'>
                <div style='background-color: white; padding: 30px; border-radius: 6px; box-shadow: 0px 2px 10px rgba(0,0,0,0.08);'>
                    <div style='text-align: center; border-bottom: 1px solid #eee; padding-bottom: 20px; margin-bottom: 20px;'>
                        <h2 style='color: {Settings.PRIMARY_COLOR}; margin-bottom: 10px; font-weight: 600;'>E-posta Adresinizi Doğrulayın</h2>
                    </div>
                    <p style='margin-bottom: 20px; line-height: 1.5;'>Merhaba,</p>
                    <p style='margin-bottom: 20px; line-height: 1.5;'>E-posta adresinizi doğrulamak için lütfen aşağıdaki kodu kullanın:</p>
                    <div style='background-color: #f0f4ff; padding: 15px; border-radius: 5px; text-align: center; margin: 25px 0;'>
                        <span style='font-size: 24px; font-weight: bold; letter-spacing: 5px; color: {Settings.PRIMARY_COLOR};'>{code}</span>
                    </div>
                    <p style='margin-bottom: 20px; line-height: 1.5;'>Bu kod <strong>15 dakika</strong> süreyle geçerlidir.</p>
                    <p style='margin-bottom: 10px; line-height: 1.5;'>Eğer bir hesap oluşturmadıysanız, lütfen bu e-postayı dikkate almayınız.</p>
                    <div style='margin-top: 30px; padding-top: 20px; border-top: 1px solid #eee; font-size: 13px; color: #777; text-align: center;'>
                        <p>Bu otomatik olarak oluşturulmuş bir e-postadır, lütfen yanıtlamayınız.</p>
                    </div>
                </div>
            </div>";
    }
} 