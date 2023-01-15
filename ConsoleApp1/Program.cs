using DesignPatterns.chainOfResponsibility;

var webServer = new WebServer(new Authenticator(new Logger(new Compressor(null))));
webServer.Handle(new HttpRequest("admin", "1234"));