﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioSoftplan.Services.Dtos
{
    public class ResCoutriesDto
    {
        public Name name { get; set; }
        public string cca2 { get; set; }
        public Currencies currencies { get; set; }
        public string[] capital { get; set; }
        public Languages languages { get; set; }
        public float area { get; set; }
        public string flag { get; set; }
        public int population { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public Nativename nativeName { get; set; }
    }

    public class Nativename
    {
        public Aym aym { get; set; }
        public Que que { get; set; }
        public Spa spa { get; set; }
    }

    public class Aym
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Que
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Spa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Currencies
    {
        public PEN PEN { get; set; }
    }

    public class PEN
    {
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Idd
    {
        public string root { get; set; }
        public string[] suffixes { get; set; }
    }

    public class Languages
    {
        public string aym { get; set; }
        public string que { get; set; }
        public string spa { get; set; }
    }

    public class Translations
    {
        public Ara ara { get; set; }
        public Ces ces { get; set; }
        public Cym cym { get; set; }
        public Deu deu { get; set; }
        public Est est { get; set; }
        public Fin fin { get; set; }
        public Fra fra { get; set; }
        public Hrv hrv { get; set; }
        public Hun hun { get; set; }
        public Ita ita { get; set; }
        public Jpn jpn { get; set; }
        public Kor kor { get; set; }
        public Nld nld { get; set; }
        public Per per { get; set; }
        public Pol pol { get; set; }
        public Por por { get; set; }
        public Rus rus { get; set; }
        public Slk slk { get; set; }
        public Spa1 spa { get; set; }
        public Swe swe { get; set; }
        public Urd urd { get; set; }
        public Zho zho { get; set; }
    }

    public class Ara
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ces
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cym
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Deu
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Est
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fra
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hrv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hun
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ita
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Jpn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kor
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nld
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Per
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pol
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Por
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Rus
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Slk
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Spa1
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Swe
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Urd
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zho
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Demonyms
    {
        public Eng eng { get; set; }
        public Fra1 fra { get; set; }
    }

    public class Eng
    {
        public string f { get; set; }
        public string m { get; set; }
    }

    public class Fra1
    {
        public string f { get; set; }
        public string m { get; set; }
    }

    public class Maps
    {
        public string googleMaps { get; set; }
        public string openStreetMaps { get; set; }
    }

    public class Gini
    {
        public float _2019 { get; set; }
    }

    public class Car
    {
        public string[] signs { get; set; }
        public string side { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class Coatofarms
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class Capitalinfo
    {
        public float[] latlng { get; set; }
    }

    public class Postalcode
    {
        public string format { get; set; }
        public string regex { get; set; }
    }
}
