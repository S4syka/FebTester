using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FebTesting;

public class Setting
{
    public bool Randomize { get; private set; }

    public int Chapter { get; private set; }

    public bool OnlyIncorrectAnswers { get; private set; }

    public Setting(bool randomize, int chapter, bool onlyIncorrectAnswers)
    {
        Randomize = randomize;
        Chapter = chapter;
        OnlyIncorrectAnswers = onlyIncorrectAnswers;
    }
}
