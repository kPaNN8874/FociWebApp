namespace FociWebApp.Models
{
    public class CsapatStatisztika
    {
        public string CsapatNev { get; set; }
        public int GyozelmekSzama { get; set; }
        public int DontetlenekSzama { get; set; }
        public int VeresegekSzama { get; set; }
        public int LottGolokSzama { get; set; }
        public int kapottGolokSzama { get; set; }
        public int JatszottMeccsekSzama { get => GyozelmekSzama + DontetlenekSzama + VeresegekSzama;}
        public int GolKulonbseg { get =>  LottGolokSzama-kapottGolokSzama; }
    }
}
