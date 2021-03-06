﻿using System;
using Xamarin.Forms;

namespace BookSwap
{
    public class Constants
    {
        public static class Colors
        {
            public static Color placeHolder = Color.FromHex("A1A1A1");
            public static Color primaryFont = Color.FromHex("9013FE");
            public static Color secondaryFont = Color.FromHex("C32AFF");
            public static Color entryFieldBackground = Color.FromHex("f2f2f2");
      }

        public static class AWSS3
        {
            public static string bucketName = "comp-490-bookswap";
      }
        public static class Strings
        {
            public static string example = "haveTwoTwinkiesAndCallMeInTheMorning";
            public static string mainPageMessage = "The best place to find or sell second hand text books";
        }

        public static class FontSizes
        {  
            public static int placeholderSize = 18;
            public static int subHeaderSize = 10;
        }
    }
}
