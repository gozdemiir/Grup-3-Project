namespace Grup_3_Project.Domain
{
    public class IlacProgrami
    {
        public string Ad { get; set; }
        public int GunlukDoz { get; set; }
        public bool TokKarni { get; set; }
        public string KarniDurumu { get; set; }
        public bool GeceMi { get; set; }

        public IlacProgrami(string ad, int gunlukDoz, bool tokKarni, string karniDurumu, bool geceMi = false)
        {
            Ad = ad;
            GunlukDoz = gunlukDoz;
            TokKarni = tokKarni;
            KarniDurumu = karniDurumu;
            GeceMi = geceMi;
        }

        public void IlacAlmak()
        {
            string zaman = GeceMi ? "gece" : "gündüz";
            Console.WriteLine($"{Ad} ilacını {zaman} {KarniDurumu} karına almak gerekiyor. Günlük doz: {GunlukDoz}");
        }
    }
}
