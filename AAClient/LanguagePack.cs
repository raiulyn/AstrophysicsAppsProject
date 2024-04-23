using System;

// RAYMOND LAI
// STUDENT ID: 30082866
// DATE: 23/04/2024

namespace AAClient
{
    // LEFTOVER CODE
    // Retained for post-mortem

    public enum LangOptions
    {
        EnglishUK,
        French,
        German
    }
    public struct LangSet
    {
        public string EnglishUK;
        public string French;
        public string German;
    }
    /// <summary>
    /// A static helper to quickly grab localized texts
    /// </summary>
    internal static class LanguagePack
    {
        // public static LangSet TEXT_Template = new LangSet { EnglishUK = "en", French = "fr", German = "fr" };

        public static LangSet TEXT_Enter = new LangSet { EnglishUK = "Enter", French = "entrer", German = "Eingeben" };
        public static LangSet TEXT_Exit = new LangSet { EnglishUK = "Exit", French = "Sortie", German = "Ausfahrt" };
        public static LangSet TEXT_Calculate = new LangSet { EnglishUK = "Calculate", French = "Calculer", German = "Berechnung" };

        public static LangSet TEXT_StarVelocity = new LangSet { EnglishUK = "en", French = "fr", German = "fr" };
        public static LangSet TEXT_StarDistance = new LangSet { EnglishUK = "en", French = "fr", German = "fr" };
        public static LangSet TEXT_TemperatureInKelvin = new LangSet { EnglishUK = "en", French = "fr", German = "fr" };
        public static LangSet TEXT_EventHorizon = new LangSet { EnglishUK = "en", French = "fr", German = "fr" };
    }
    
}
