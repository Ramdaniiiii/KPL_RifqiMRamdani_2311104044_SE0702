﻿using System;
using System.Collections.Generic;

class KodeBuah
{
    private static Dictionary<string, string> kodeBuahDict = new Dictionary<string, string>
    {
        { "Apel", "A00" }, { "Aprikot", "B00" }, { "Alpukat", "C00" },
        { "Pisang", "D00" }, { "Paprika", "E00" }, { "Kurma", "K00" },
        { "Durian", "L00" }, { "Anggur", "M00" }, { "Melon", "N00" },
        { "Semangka", "O00" }
    };

    public static string GetKodeBuah(string namaBuah)
    {
        return kodeBuahDict.ContainsKey(namaBuah) ? kodeBuahDict[namaBuah] : "Kode Tidak Ditemukan";
    }
}