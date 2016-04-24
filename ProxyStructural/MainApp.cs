using System;

namespace ProxyStructural {
    class MainApp {
        static void Main() {
            Proxy proxy = new Proxy();
            proxy.Request();
            //Wait for user
            Console.ReadKey();
        }
    }
}