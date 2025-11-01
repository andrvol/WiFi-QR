using QRCoder;

var wifiPayload = new PayloadGenerator.WiFi
(
    ssid: "MyWiFi",
    password: "123456",
    authenticationMode: PayloadGenerator.WiFi.Authentication.WPA
);
string qrText = wifiPayload.ToString();

using var generator = new QRCodeGenerator();

QRCodeData data = generator. CreateQrCode (
    qrText, QRCodeGenerator. ECCLevel. Q);

using var qrCode = new PngByteQRCode (data) ;
byte[] pngBytes = qrCode. GetGraphic (20) ;

File.WriteAllBytes("wifi.png", pngBytes);