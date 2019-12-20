using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SageFoundation.Playground {
    class Misc {

        public static void Go() {
            DateTime? todayDateTime = DateTime.Now;
            Assert.That(todayDateTime, Is.InstanceOf<DateTime>());
            Console.WriteLine("OK");

            try {
                DateTime? nullDateTime = null;
                Assert.That(nullDateTime, Is.InstanceOf<DateTime>());
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}