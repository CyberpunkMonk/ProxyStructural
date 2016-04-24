using System;
namespace ProxyStructural {
    class RealSubject:Subject {
        public override void Request() {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}