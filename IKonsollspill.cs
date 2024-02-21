
namespace SpillBibliotek_ConsoleApp
{
    internal interface IKonsollspill
    {
        void TrekkeUtRandomSpill();
        void ShowKonsollspillInfo();
        void ShowKonsollType();
        void LeggeTilSpill(Spill spill);
        void FjerneSpill(int Index);
    }
}
