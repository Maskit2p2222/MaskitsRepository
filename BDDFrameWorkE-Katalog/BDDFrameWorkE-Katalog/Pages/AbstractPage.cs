﻿using OpenQA.Selenium;

namespace BDDFrameWorkE_Katalog.Pages
{
    class AbstractPage
    {
        protected readonly IWebDriver driver;
        protected readonly int MaxDelaySeconds;
        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
            MaxDelaySeconds = 10;
        }
    }
}
