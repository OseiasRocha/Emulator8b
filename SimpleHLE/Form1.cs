using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleHLE {
    public partial class Form1 : Form {
        public CheckBox[] OUTPUT1 = new CheckBox[8];
        public CheckBox[] OUTPUT2 = new CheckBox[8];

        public Form1() {
            InitializeComponent();

            OUTPUT1[0] = OUTPUT1P0;
            OUTPUT1[1] = OUTPUT1P1;
            OUTPUT1[2] = OUTPUT1P2;
            OUTPUT1[3] = OUTPUT1P3;
            OUTPUT1[4] = OUTPUT1P4;
            OUTPUT1[5] = OUTPUT1P5;
            OUTPUT1[6] = OUTPUT1P6;
            OUTPUT1[7] = OUTPUT1P7;
            OUTPUT2[0] = OUTPUT2P0;
            OUTPUT2[1] = OUTPUT2P1;
            OUTPUT2[2] = OUTPUT2P2;
            OUTPUT2[3] = OUTPUT2P3;
            OUTPUT2[4] = OUTPUT2P4;
            OUTPUT2[5] = OUTPUT2P5;
            OUTPUT2[6] = OUTPUT2P6;
            OUTPUT2[7] = OUTPUT2P7;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void buttonCompile_Click(object sender, EventArgs e) {
            Code.Compile(textBoxCode.Text);
            if (Code.Error != "") {
                textBoxOpcode.Text = Code.Error;
                return;
            }

            string s = "";
            foreach (byte b in Code.ROM) {
                s += b.ToString("X2");
            }
            textBoxOpcode.Text = s;

            CPU.WriteROM(Code.ROM);

        }

        private void buttonReset_Click(object sender, EventArgs e) {
            CPU.Reset();
            UpdateGui();
        }

        private void buttonClock_Click(object sender, EventArgs e) {
            CPU.Clock();
            UpdateGui();
        }

        private void UpdateGui() {
            textBoxClock.Text = CPU.CLOCK.ToString();
            textBoxProgramCounter.Text = CPU.PC.ToString("x2").ToUpper();
            string a = CPU.R01.ToString("x2").ToUpper();
            textBoxR01.Text = CPU.R01.ToString("x2").ToUpper();
            textBoxR02.Text = CPU.R02.ToString("x2").ToUpper();
            textBoxR03.Text = CPU.R03.ToString("x2").ToUpper();
            textBoxR04.Text = CPU.R04.ToString("x2").ToUpper();
            textBoxALU.Text = CPU.ALU.ToString("x2").ToUpper();
            textBoxBus.Text = CPU.BUS.ToString("x2").ToUpper();
            textBoxUnityControl0.Text = CPU.UC0.ToString("x2").ToUpper();
            textBoxUnityControl1.Text = CPU.UC1.ToString("x2").ToUpper();
            textBoxUnityControl2.Text = CPU.UC2.ToString("x2").ToUpper();
            string str = Convert.ToString(CPU.OUTPUT1, 2);
            while(str.Length < 8) str = str.Insert(0, "0");
            for(int i=0; i < OUTPUT1.Length; i++){
                OUTPUT1[i].CheckState = str[7 - i] == '1' ? CheckState.Indeterminate : CheckState.Unchecked;
            }
            str = Convert.ToString(CPU.OUTPUT2, 2);
            while (str.Length < 8) str = str.Insert(0, "0");
            for (int i = 0; i < OUTPUT2.Length; i++)
            {
                OUTPUT2[i].CheckState = str[7 - i] == '1' ? CheckState.Indeterminate : CheckState.Unchecked;
            }
            checkBoxSRZero.Checked = CPU.SRZERO;
            if (CPU.FAIL) {
                textBoxInstruction.Text = "FAIL";
            } else if (!CPU.RUNNING) {
                textBoxInstruction.Text = "HLT";
            } else {
                switch (CPU.UC0) {
                    case Consts.MOV:
                        textBoxInstruction.Text = "MOV";
                        break;
                    case Consts.INC:
                        textBoxInstruction.Text = "INC";
                        break;
                    case Consts.DEC:
                        textBoxInstruction.Text = "DEC";
                        break;
                    case Consts.CMP:
                        textBoxInstruction.Text = "CMP";
                        break;
                    case Consts.JNZ:
                        textBoxInstruction.Text = "JNZ";
                        break;
                    case Consts.OUT:
                        textBoxInstruction.Text = "OUT";
                        break;
                    default:
                        break;
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e) {
            CPU.Reset();
            CPU.Run();
            UpdateGui();
        }
    }


    public static class Consts {
        public const byte HLT = 0x00;
        public const byte MOV = 0x01;
        public const byte STO = 0x02;
        public const byte INC = 0x03;
        public const byte DEC = 0x04;
        public const byte CMP = 0x05;
        public const byte JNZ = 0x06;
        public const byte OUT = 0x07;

        public const byte ALU = 0x00;
        public const byte R01 = 0x01;
        public const byte R02 = 0x02;
        public const byte R03 = 0x03;
        public const byte R04 = 0x04;
        public const byte O01 = 0x05;
        public const byte O02 = 0x06;

        public static byte GetByName(string name) {
            if (typeof(Consts).GetFields().Where(x => x.Name == name).Count() > 0) {
                return (byte)typeof(Consts).GetField(name)?.GetValue(null);
            }
            return 0xff;
        }
    }



    public static class Code {
        public static string Error = "";
        public static byte[] ROM = new byte[128];

        public static void Compile(string code) {
            var c = code.ToUpper().Replace("\r\n", "\n");
            int pc = 0;
            foreach (var line in c.Split('\n')) {
                if (line.Trim().Length < 3) continue;
                var ins = Instruction(line.Trim());
                if (Error != "" || ins is null) {
                    Error += " - Instruction is null";
                    return;
                }
                foreach (byte b in ins) {
                    ROM[pc++] = b;
                }
            }

        }

        private static byte[] Instruction(string ins) {
            while (ins.Contains("  ")) ins = ins.Replace("  ", " ");
            while (ins.Contains(", ")) ins = ins.Replace(", ", ",");
            var mnm = ins.Split(' ')[0];
            switch (mnm) {
                case "MOV":
                    return MOV(ins);
                case "STO":
                    return STO(ins);
                case "INC":
                    return INC(ins);
                case "DEC":
                    return DEC(ins);
                case "CMP":
                    return CMP(ins);
                case "JNZ":
                    return JNZ(ins);
                case "OUT":
                    return OUT(ins);
                default:
                    return HLT();
            }
        }

        // HLT
        static byte[] HLT() {
            return new byte[1] { Consts.HLT };
        }

        // MOV
        static byte[] MOV(string ins) {
            try {
                byte[] b = new byte[3];
                var dst = ins.Split(' ')[1].Split(',')[0];
                var val = ins.Split(' ')[1].Split(',')[1];
                b[0] = Consts.MOV;
                b[1] = Consts.GetByName(dst);
                b[2] = Convert.ToByte(val, 16);
                return b;
            } catch (Exception) {
                Error = "Fail to decode MOV";
            }
            return null;
        }

        // STO
        static byte[] STO(string ins) {
            try {
                byte[] b = new byte[2];
                var dst = ins.Split(' ')[1].Split(',')[0];
                b[0] = Consts.STO;
                b[1] = Consts.GetByName(dst);
                return b;
            } catch (Exception) {
                Error = "Fail to decode STO";
            }
            return null;
        }

        // INC
        static byte[] INC(string ins) {
            try {
                byte[] b = new byte[2];
                var dst = ins.Split(' ')[1].Split(',')[0];
                b[0] = Consts.INC;
                b[1] = Consts.GetByName(dst);
                return b;
            } catch (Exception) {
                Error = "Fail to decode INC";
            }
            return null;
        }

        // DEC
        static byte[] DEC(string ins) {
            try {
                byte[] b = new byte[2];
                var dst = ins.Split(' ')[1].Split(',')[0];
                b[0] = Consts.DEC;
                b[1] = Consts.GetByName(dst);
                return b;
            } catch (Exception) {
                Error = "Fail to decode DEC";
            }
            return null;
        }

        // CMP
        static byte[] CMP(string ins) {
            try {
                byte[] b = new byte[3];
                var dst = ins.Split(' ')[1].Split(',')[0];
                var val = ins.Split(' ')[1].Split(',')[1];
                b[0] = Consts.CMP;
                b[1] = Consts.GetByName(dst);
                b[2] = Consts.GetByName(val);
                return b;
            } catch (Exception) {
                Error = "Fail to decode MOV";
            }
            return null;
        }

        // JNZ
        static byte[] JNZ(string ins) {
            try {
                byte[] b = new byte[2];
                var val = ins.Split(' ')[1].Split(',')[0];
                b[0] = Consts.JNZ;
                b[1] = Convert.ToByte(val, 16);
                return b;
            } catch (Exception) {
                Error = "Fail to decode JNZ";
            }
            return null;
        }

        // OUT
        static byte[] OUT(string ins) {
            try {
                byte[] b = new byte[3];
                var dst = ins.Split(' ')[1].Split(',')[0];
                var val = ins.Split(' ')[1].Split(',')[1];
                b[0] = Consts.OUT;
                b[1] = Consts.GetByName(dst);
                b[2] = Consts.GetByName(val);
                return b;
            } catch (Exception) {
                Error = "Fail to decode OUT";
            }
            return null;
        }
    }

    public static class CPU {
        public static byte PC = 0;
        public static byte ALU = 0;
        public static byte R01 = 0;
        public static byte R02 = 0;
        public static byte R03 = 0;
        public static byte R04 = 0;
        public static byte BUS = 0;
        public static byte OUTPUT1 = 0;
        public static byte OUTPUT2 = 0;
        public static byte UC0 = 0;
        public static byte UC1 = 0;
        public static byte UC2 = 0;
        public static byte[] ROM = new byte[128];
        public static bool SRZERO = false;
        public static bool FAIL = false;
        public static bool RUNNING = true;
        public static int CLOCK = 0;

        public static void WriteROM(byte[] rom) {
            ROM = rom;
        }

        public static void Reset() {
            PC = ALU = R01 = R02 = R03 = R04 = 0;
            BUS = 0;
            OUTPUT1 = 0;
            OUTPUT2 = 0;
            UC0 = UC1 = UC2 = 0;
            SRZERO = false;
            FAIL = false;
            RUNNING = true;
            CLOCK = 0;
        }

        public static void Run() {
            while (RUNNING && !FAIL) {
                Clock();
            }
        }

        public static void Clock() {
            if (RUNNING && !FAIL) {
                Fetch();
                Decode();
            }
        }

        public static void Fetch() {
            BUS = ROM[PC++];
            if (PC >= 128) {
                HLT();
                return;
            }
            CLOCK++;
        }


        public static void Decode() {
            switch (BUS) {
                case Consts.HLT:
                    HLT();
                    break;
                case Consts.MOV:
                    MOV();
                    break;
                case Consts.STO:
                    STO();
                    break;
                case Consts.INC:
                    INC();
                    break;
                case Consts.DEC:
                    DEC();
                    break;
                case Consts.CMP:
                    CMP();
                    break;
                case Consts.JNZ:
                    JNZ();
                    break;
                case Consts.OUT:
                    OUT();
                    break;
                default:
                    break;
            }
            ALUSUM();
        }

        // ALUSUM 
        public static void ALUSUM() {
            ALU = (byte)(R01 + R02);
        }

        public static void HLT() {
            RUNNING = false;
        }

        public static void MOV() {
            CLOCK++;
            UC0 = Consts.MOV;
            Fetch();
            UC1 = BUS;
            Fetch();
            UC2 = BUS;
            switch (UC1) {
                case Consts.R01:
                    R01WriteEnable();
                    break;
                case Consts.R02:
                    R02WriteEnable();
                    break;
                case Consts.R03:
                    R03WriteEnable();
                    break;
                case Consts.R04:
                    R04WriteEnable();
                    break;
                default:
                    FAIL = true;
                    break;
            }
        }

        public static void OUTPUT1WriteEnable() {
            OUTPUT1 = BUS;
        }
        public static void OUTPUT2WriteEnable()
        {
            OUTPUT2 = BUS;
        }
        public static void R01WriteEnable() {
            R01 = BUS;
        }
        public static void R02WriteEnable() {
            R02 = BUS;
        }
        public static void R03WriteEnable() {
            R03 = BUS;
        }
        public static void R04WriteEnable()
        {
            R04 = BUS;
        }
        public static void R01ReadEnable() {
            BUS = R01;
        }
        public static void R02ReadEnable() {
            BUS = R02;
        }
        public static void R03ReadEnable() {
            BUS = R03;
        }
        public static void R04ReadEnable()
        {
            BUS = R04;
        }
        public static void ALUReadEnable() {
            BUS = ALU;
        }


        public static void INC() {
            CLOCK++;
            UC0 = Consts.INC;
            Fetch();
            switch (BUS) {
                case Consts.R01:
                    R01++;
                    break;
                case Consts.R02:
                    R02++;
                    break;
                case Consts.R03:
                    R03++;
                    break;
                case Consts.R04:
                    R04++;
                    break;
                default:
                    FAIL = true;
                    break;
            }
        }

        public static void DEC() {
            CLOCK++;
            UC0 = Consts.INC;
            Fetch();
            switch (BUS) {
                case Consts.R01:
                    R01--;
                    break;
                case Consts.R02:
                    R02--;
                    break;
                case Consts.R03:
                    R03--;
                    break;
                case Consts.R04:
                    R04--;
                    break;
                default:
                    FAIL = true;
                    break;
            }
        }


        public static void CMP() {
            CLOCK++;
            UC0 = Consts.CMP;
            Fetch();
            UC1 = BUS;
            Fetch();
            UC2 = BUS;
            switch (UC1) {
                case Consts.R01:
                    R01ReadEnable();
                    break;
                case Consts.R02:
                    R02ReadEnable();
                    break;
                case Consts.R03:
                    R03ReadEnable();
                    break;
                case Consts.R04:
                    R04ReadEnable();
                    break;
                default:
                    FAIL = true;
                    break;
            }
            switch (UC2) {
                case Consts.R01:
                    SRZERO = BUS == R01;
                    break;
                case Consts.R02:
                    SRZERO = BUS == R02;
                    break;
                case Consts.R03:
                    SRZERO = BUS == R03;
                    break;
                case Consts.R04:
                    SRZERO = BUS == R04;
                    break;
                default:
                    FAIL = true;
                    break;
            }

        }

        public static void JNZ() {
            CLOCK++;
            UC0 = Consts.JNZ;
            Fetch();
            if(!SRZERO) {
                PC = BUS;
            }
        }

        public static void STO() {
            CLOCK++;
            UC0 = Consts.STO;
            Fetch();
            UC1 = BUS;
            ALUReadEnable();
            switch (UC1) {
                case Consts.R01:
                    R01WriteEnable();
                    break;
                case Consts.R02:
                    R02WriteEnable();
                    break;
                case Consts.R03:
                    R03WriteEnable();
                    break;
                case Consts.R04:
                    R04WriteEnable();
                    break;
                default:
                    FAIL = true;
                    break;
            }
        }

        public static void OUT() {
            CLOCK++;
            UC0 = Consts.OUT;
            Fetch();
            UC1 = BUS;
            Fetch();
            UC2 = BUS;
            switch (UC2) {
                case Consts.R01:
                    R01ReadEnable();
                    break;
                case Consts.R02:
                    R02ReadEnable();
                    break;
                case Consts.R03:
                    R03ReadEnable();
                    break;
                case Consts.R04:
                    R04ReadEnable();
                    break;
                default:
                    FAIL = true;
                    break;
            }
            switch (UC1)
            {
                case Consts.O01:
                    OUTPUT1WriteEnable();
                    break;
                case Consts.O02:
                    OUTPUT2WriteEnable();
                    break;
                default:
                    FAIL = true;
                    break;
            }
        }
    }
}
