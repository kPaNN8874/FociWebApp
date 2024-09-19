namespace FociWebApp.Models
{
    public class CsapatStatisztika
    {
        public string CsapatNev { get; set; }
        public int GyozelmekSzama { get; set; }
        public int DontetlenekSzama { get; set; }
        public int VeresegekSzam { get; set; }
        public int LottGolokSzama { get; set; }
        public int kapottGolokSzama { get; set; }
        public int JatszottMeccsekSzama { get => GyozelmekSzama+DontetlenekSzama+VeresegekSzam set; }
        public int GolKulonbseg { get =>  ; }
    }
}
