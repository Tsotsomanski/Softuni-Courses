using System;
using WindowsFormsApplication1.Interface.IPadaun.IPaduinStudents;
using WindowsFormsApplication1.Paduins.Paduin;

namespace WindowsFormsApplication1.Paduins
{
    public class PadoinFactor
    {
        public static IPaduin CreatPaduin(PaduinType type)
        {
            switch (type)
            {
                case PaduinType.Karnotman:
                    return new Karnobatman();
                case PaduinType.CountSevgin:
                    return new CountSevgin();
                case PaduinType.SashoFett:
                    return new SashoFett();
                    case PaduinType.WightJan:
                    return new WightJan();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
