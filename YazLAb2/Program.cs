using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

string textFile = "C:/Users/Yonis/OneDrive/Masaüstü/paroje 2/rows.csv";
string dosya_yolu = @"C:/Users/Yonis/OneDrive/Masaüstü/paroje 2/organized.csv";
FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
StreamWriter sw = new StreamWriter(fs);
string[] stopWords = {
            "ourselves",
            "hers",
            "between",
            "yourself",
            "but",
            "again",
            "there",
            "about",
            "there",
            "about",
            "once",
            "during",
            "out",
            "very",
            "having",
            "with",
            "they",
            "own",
            "an",
            "be",
            "some",
            "for",
            "do",
            "its",
            "yours",
            "such",
            "into",
            "of",
            "most",
            "itself",
            "other",
            "off",
            "is",
            "s",
            "am",
            "or",
            "who",
            "as",
            "from",
            "him",
            "each",
            "the",
            "themselves",
            "until",
            "bellow",
            "are",
            "we",
            "these",
            "your",
            "his",
            "through",
            "don",
            "nor",
            "me",
            "were",
            "her",
            "more",
            "himself",
            "this",
            "down",
            "should",
            "our",
            "their",
            "while",
            "above",
            "both",
            "up",
            "to",
            "ours",
            "had",
            "she",
            "all",
            "no",
            "when",
            "at",
            "any",
            "before",
            "them",
            "same",
            "and",
            "been",
            "have",
            "in",
            "will",
            "on",
            "does",
            "yourselves",
            "then",
            "that",
            "because",
            "what",
            "over",
            "why",
            "so",
            "can",
"did",
            "not",
            "now",
            "under",
            "he",
            "you",
            "herself",
            "has",
            "just",
            "where",
            "too",
            "only",
            "myself",
            "which",
            "those",
            "i",
            "after",
            "few",
            "whom",
            "t",
            "being",
            "if",
            "theirs",
            "my",
            "against",
            "a",
            "by",
            "doing",
            "it",
            "how",
            "further",
            "was",
            "here",
            "than"
    };


string[] lines = File.ReadAllLines(textFile);
string organized = "";
foreach (string line in lines)
{
    if (line.Split(',').Length == 18)
    {


        organized = line;
        List<string> strings = new List<string>();
        strings = organized.Split(" ").ToList();
        foreach (string word in stopWords)
        {

            for (var i = 0; i < strings.Count; i++)
            {

                if (strings[i] == word)
                {
                    strings.RemoveAt(i);
                }
            }


        }
        string finText = "";
        for (var i = 0; i < strings.Count; i++)
        {
            finText += strings[i] + " ";
        }
        sw.WriteLine(finText);
        sw.Flush();
    }
}
Console.WriteLine("Done!");


