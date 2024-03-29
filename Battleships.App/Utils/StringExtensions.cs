﻿using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;

namespace Battleships.App.Utils
{
    public static class StringExtensions
    {
        /// <summary>
        /// Validates proper coordinates format of input string from the user.
        /// </summary>
        /// <param name="shot">User input string</param>
        /// <returns>The method returns bool</returns>
        public static bool IsProperShot(this string? shot)
        {
            if (shot is null) return false;
            if (shot.Length != 2) return false;
            if (!char.IsLetter(shot[0])) return false;
            if (!char.IsUpper(shot[0])) return false;
            if (!Regex.IsMatch(shot, "^[A-J].*")) return false;
            if (!char.IsDigit(shot[1])) return false;
            
            return true;
        }
    }
}