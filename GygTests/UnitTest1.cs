using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;

namespace GygTests
{
    [TestClass]
    public class UnitTest1
    {
        AppiumDriver<AndroidElement> _driver;
        [TestMethod]
        public void TestMethod1()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "Galaxy S6");
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("appPackage", "com.guzmanygomez.gyg.uat");
            cap.SetCapability("appActivity", "com.guzmanygomez.gyg.ui.activities.MainActivity");
            cap.SetCapability("autoGrantPermissions", "true");
            cap.SetCapability("noReset", "true");
            cap.SetCapability("fullReset", "false");
            cap.SetCapability("VERSION", "6.0.1");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[2]").Click();
            _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.RelativeLayout/android.widget.EditText").SendKeys("Newtown");
            TouchAction action = new TouchAction(_driver);
            action.Tap(252, 577);
            action.Release();
            action.Perform();
        }
    }
}
