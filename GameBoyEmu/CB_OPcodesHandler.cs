namespace GameBoyEmu;

public class CB_OPcodesHandler
{
   public Dictionary<ushort, OPcode> OPcodes;

   public CB_OPcodesHandler()
   {
       OPcodes = InitOpcodes();
   }
     public Dictionary<ushort, OPcode> InitOpcodes()
       {
          return new Dictionary<ushort, OPcode>
          {
              {0x00, new OPcode("RLC B", 2, 0, 4)}, {0x01, new OPcode("RLC C", 2, 0, 4)},
              {0x02, new OPcode("RLC D", 2, 0, 4)}, {0x03, new OPcode("RLC E", 2, 0, 4)},
              {0x04, new OPcode("RLC H", 2, 0, 4)}, {0x05, new OPcode("RLC L", 2, 0, 4)},
              {0x06, new OPcode("RLC (HL)", 2, 0, 4)}, {0x07, new OPcode("RLC A", 2, 0, 4)},
              {0x08, new OPcode("RRC B", 2, 0, 4)}, {0x09, new OPcode("RRC C", 2, 0, 4)},
              {0x0a, new OPcode("RRC D", 2, 0, 4)}, {0x0b, new OPcode("RRC E", 2, 0, 4)},
              {0x0c, new OPcode("RRC H", 2, 0, 4)}, {0x0d, new OPcode("RRC L", 2, 0, 4)},
              {0x0e, new OPcode("RRC (HL)", 2, 0, 4)}, {0x0f, new OPcode("RRC A", 2, 0, 4)},
              {0x10, new OPcode("RL B", 2, 0, 4)}, {0x11, new OPcode("RL C", 2, 0, 4)},
              {0x12, new OPcode("RL D", 2, 0, 4)}, {0x13, new OPcode("RL E", 2, 0, 4)},
              {0x14, new OPcode("RL H", 2, 0, 4)}, {0x15, new OPcode("RL L", 2, 0, 4)},
              {0x16, new OPcode("RL (HL)", 2, 0, 4)}, {0x17, new OPcode("RL A", 2, 0, 4)},
              {0x18, new OPcode("RR B", 2, 0, 4)}, {0x19, new OPcode("RR C", 2, 0, 4)},
              {0x1a, new OPcode("RR D", 2, 0, 4)}, {0x1b, new OPcode("RR E", 2, 0, 4)},
              {0x1c, new OPcode("RR H", 2, 0, 4)}, {0x1d, new OPcode("RR L", 2, 0, 4)},
              {0x1e, new OPcode("RR (HL)", 2, 0, 4)}, {0x1f, new OPcode("RR A", 2, 0, 4)},
              {0x20, new OPcode("SLA B", 2, 0, 4)}, {0x21, new OPcode("SLA C", 2, 0, 4)},
              {0x22, new OPcode("SLA D", 2, 0, 4)}, {0x23, new OPcode("SLA E", 2, 0, 4)},
              {0x24, new OPcode("SLA H", 2, 0, 4)}, {0x25, new OPcode("SLA L", 2, 0, 4)},
              {0x26, new OPcode("SLA (HL)", 2, 0, 4)}, {0x27, new OPcode("SLA A", 2, 0, 4)},
              {0x28, new OPcode("SRA B", 2, 0, 4)}, {0x29, new OPcode("SRA C", 2, 0, 4)},
              {0x2a, new OPcode("SRA D", 2, 0, 4)}, {0x2b, new OPcode("SRA E", 2, 0, 4)},
              {0x2c, new OPcode("SRA H", 2, 0, 4)}, {0x2d, new OPcode("SRA L", 2, 0, 4)},
              {0x2e, new OPcode("SRA (HL)", 2, 0, 4)}, {0x2f, new OPcode("SRA A", 2, 0, 4)},
              {0x30, new OPcode("SWAP B", 2, 0, 4)}, {0x31, new OPcode("SWAP C", 2, 0, 4)},
              {0x32, new OPcode("SWAP D", 2, 0, 4)}, {0x33, new OPcode("SWAP E", 2, 0, 4)},
              {0x34, new OPcode("SWAP H", 2, 0, 4)}, {0x35, new OPcode("SWAP L", 2, 0, 4)},
              {0x36, new OPcode("SWAP (HL)", 2, 0, 4)}, {0x37, new OPcode("SWAP A", 2, 0, 4)},
              {0x38, new OPcode("SRL B", 2, 0, 4)}, {0x39, new OPcode("SRL C", 2, 0, 4)},
              {0x3a, new OPcode("SRL D", 2, 0, 4)}, {0x3b, new OPcode("SRL E", 2, 0, 4)},
              {0x3c, new OPcode("SRL H", 2, 0, 4)}, {0x3d, new OPcode("SRL L", 2, 0, 4)},
              {0x3e, new OPcode("SRL (HL)", 2, 0, 4)}, {0x3f, new OPcode("SRL A", 2, 0, 4)},
              {0x40, new OPcode("BIT 0,B", 2, 0, 4)}, {0x41, new OPcode("BIT 0,C", 2, 0, 4)},
              {0x42, new OPcode("BIT 0,D", 2, 0, 4)}, {0x43, new OPcode("BIT 0,E", 2, 0, 4)},
              {0x44, new OPcode("BIT 0,H", 2, 0, 4)}, {0x45, new OPcode("BIT 0,L", 2, 0, 4)},
              {0x46, new OPcode("BIT 0,(HL)", 2, 0, 4)}, {0x47, new OPcode("BIT 0,A", 2, 0, 4)},
              {0x48, new OPcode("BIT 1,B", 2, 0, 4)}, {0x49, new OPcode("BIT 1,C", 2, 0, 4)},
              {0x4a, new OPcode("BIT 1,D", 2, 0, 4)}, {0x4b, new OPcode("BIT 1,E", 2, 0, 4)},
              {0x4c, new OPcode("BIT 1,H", 2, 0, 4)}, {0x4d, new OPcode("BIT 1,L", 2, 0, 4)},
              {0x4e, new OPcode("BIT 1,(HL)", 2, 0, 4)}, {0x4f, new OPcode("BIT 1,A", 2, 0, 4)},
              {0x50, new OPcode("BIT 2,B", 2, 0, 4)}, {0x51, new OPcode("BIT 2,C", 2, 0, 4)},
              {0x52, new OPcode("BIT 2,D", 2, 0, 4)}, {0x53, new OPcode("BIT 2,E", 2, 0, 4)},
              {0x54, new OPcode("BIT 2,H", 2, 0, 4)}, {0x55, new OPcode("BIT 2,L", 2, 0, 4)},
              {0x56, new OPcode("BIT 2,(HL)", 2, 0, 4)}, {0x57, new OPcode("BIT 2,A", 2, 0, 4)},
              {0x58, new OPcode("BIT 3,B", 2, 0, 4)}, {0x59, new OPcode("BIT 3,C", 2, 0, 4)},
              {0x5a, new OPcode("BIT 3,D", 2, 0, 4)}, {0x5b, new OPcode("BIT 3,E", 2, 0, 4)},
              {0x5c, new OPcode("BIT 3,H", 2, 0, 4)}, {0x5d, new OPcode("BIT 3,L", 2, 0, 4)},
              {0x5e, new OPcode("BIT 3,(HL)", 2, 0, 4)}, {0x5f, new OPcode("BIT 3,A", 2, 0, 4)},
              {0x60, new OPcode("BIT 4,B", 2, 0, 4)}, {0x61, new OPcode("BIT 4,C", 2, 0, 4)},
              {0x62, new OPcode("BIT 4,D", 2, 0, 4)}, {0x63, new OPcode("BIT 4,E", 2, 0, 4)},
              {0x64, new OPcode("BIT 4,H", 2, 0, 4)}, {0x65, new OPcode("BIT 4,L", 2, 0, 4)},
              {0x66, new OPcode("BIT 4,(HL)", 2, 0, 4)}, {0x67, new OPcode("BIT 4,A", 2, 0, 4)},
              {0x68, new OPcode("BIT 5,B", 2, 0, 4)}, {0x69, new OPcode("BIT 5,C", 2, 0, 4)},
              {0x6a, new OPcode("BIT 5,D", 2, 0, 4)}, {0x6b, new OPcode("BIT 5,E", 2, 0, 4)},
              {0x6c, new OPcode("BIT 5,H", 2, 0, 4)}, {0x6d, new OPcode("BIT 5,L", 2, 0, 4)},
              {0x6e, new OPcode("BIT 5,(HL)", 2, 0, 4)}, {0x6f, new OPcode("BIT 5,A", 2, 0, 4)},
              {0x70, new OPcode("BIT 6,B", 2, 0, 4)}, {0x71, new OPcode("BIT 6,C", 2, 0, 4)},
              {0x72, new OPcode("BIT 6,D", 2, 0, 4)}, {0x73, new OPcode("BIT 6,E", 2, 0, 4)},
              {0x74, new OPcode("BIT 6,H", 2, 0, 4)}, {0x75, new OPcode("BIT 6,L", 2, 0, 4)},
              {0x76, new OPcode("BIT 6,(HL)", 2, 0, 4)}, {0x77, new OPcode("BIT 6,A", 2, 0, 4)},
              {0x78, new OPcode("BIT 7,B", 2, 0, 4)}, {0x79, new OPcode("BIT 7,C", 2, 0, 4)},
              {0x7a, new OPcode("BIT 7,D", 2, 0, 4)}, {0x7b, new OPcode("BIT 7,E", 2, 0, 4)},
              {0x7c, new OPcode("BIT 7,H", 2, 0, 4)}, {0x7d, new OPcode("BIT 7,L", 2, 0, 4)},
              {0x7e, new OPcode("BIT 7,(HL)", 2, 0, 4)}, {0x7f, new OPcode("BIT 7,A", 2, 0, 4)},
              {0x80, new OPcode("RES 0,B", 2, 0, 4)}, {0x81, new OPcode("RES 0,C", 2, 0, 4)},
              {0x82, new OPcode("RES 0,D", 2, 0, 4)}, {0x83, new OPcode("RES 0,E", 2, 0, 4)},
              {0x84, new OPcode("RES 0,H", 2, 0, 4)}, {0x85, new OPcode("RES 0,L", 2, 0, 4)},
              {0x86, new OPcode("RES 0,(HL)", 2, 0, 4)}, {0x87, new OPcode("RES 0,A", 2, 0, 4)},
              {0x88, new OPcode("RES 1,B", 2, 0, 4)}, {0x89, new OPcode("RES 1,C", 2, 0, 4)},
              {0x8a, new OPcode("RES 1,D", 2, 0, 4)}, {0x8b, new OPcode("RES 1,E", 2, 0, 4)},
              {0x8c, new OPcode("RES 1,H", 2, 0, 4)}, {0x8d, new OPcode("RES 1,L", 2, 0, 4)},
              {0x8e, new OPcode("RES 1,(HL)", 2, 0, 4)}, {0x8f, new OPcode("RES 1,A", 2, 0, 4)},
              {0x90, new OPcode("RES 2,B", 2, 0, 4)}, {0x91, new OPcode("RES 2,C", 2, 0, 4)},
              {0x92, new OPcode("RES 2,D", 2, 0, 4)}, {0x93, new OPcode("RES 2,E", 2, 0, 4)},
              {0x94, new OPcode("RES 2,H", 2, 0, 4)}, {0x95, new OPcode("RES 2,L", 2, 0, 4)},
              {0x96, new OPcode("RES 2,(HL)", 2, 0, 4)}, {0x97, new OPcode("RES 2,A", 2, 0, 4)},
              {0x98, new OPcode("RES 3,B", 2, 0, 4)}, {0x99, new OPcode("RES 3,C", 2, 0, 4)},
              {0x9a, new OPcode("RES 3,D", 2, 0, 4)}, {0x9b, new OPcode("RES 3,E", 2, 0, 4)},
              {0x9c, new OPcode("RES 3,H", 2, 0, 4)}, {0x9d, new OPcode("RES 3,L", 2, 0, 4)},
              {0x9e, new OPcode("RES 3,(HL)", 2, 0, 4)}, {0x9f, new OPcode("RES 3,A", 2, 0, 4)},
              {0xa0, new OPcode("RES 4,B", 2, 0, 4)}, {0xa1, new OPcode("RES 4,C", 2, 0, 4)},
              {0xa2, new OPcode("RES 4,D", 2, 0, 4)}, {0xa3, new OPcode("RES 4,E", 2, 0, 4)},
              {0xa4, new OPcode("RES 4,H", 2, 0, 4)}, {0xa5, new OPcode("RES 4,L", 2, 0, 4)},
              {0xa6, new OPcode("RES 4,(HL)", 2, 0, 4)}, {0xa7, new OPcode("RES 4,A", 2, 0, 4)},
              {0xa8, new OPcode("RES 5,B", 2, 0, 4)}, {0xa9, new OPcode("RES 5,C", 2, 0, 4)},
              {0xaa, new OPcode("RES 5,D", 2, 0, 4)}, {0xab, new OPcode("RES 5,E", 2, 0, 4)},
              {0xac, new OPcode("RES 5,H", 2, 0, 4)}, {0xad, new OPcode("RES 5,L", 2, 0, 4)},
              {0xae, new OPcode("RES 5,(HL)", 2, 0, 4)}, {0xaf, new OPcode("RES 5,A", 2, 0, 4)},
              {0xb0, new OPcode("RES 6,B", 2, 0, 4)}, {0xb1, new OPcode("RES 6,C", 2, 0, 4)},
              {0xb2, new OPcode("RES 6,D", 2, 0, 4)}, {0xb3, new OPcode("RES 6,E", 2, 0, 4)},
              {0xb4, new OPcode("RES 6,H", 2, 0, 4)}, {0xb5, new OPcode("RES 6,L", 2, 0, 4)},
              {0xb6, new OPcode("RES 6,(HL)", 2, 0, 4)}, {0xb7, new OPcode("RES 6,A", 2, 0, 4)},
              {0xb8, new OPcode("RES 7,B", 2, 0, 4)}, {0xb9, new OPcode("RES 7,C", 2, 0, 4)},
              {0xba, new OPcode("RES 7,D", 2, 0, 4)}, {0xbb, new OPcode("RES 7,E", 2, 0, 4)},
              {0xbc, new OPcode("RES 7,H", 2, 0, 4)}, {0xbd, new OPcode("RES 7,L", 2, 0, 4)},
              {0xbe, new OPcode("RES 7,(HL)", 2, 0, 4)}, {0xbf, new OPcode("RES 7,A", 2, 0, 4)},
              {0xc0, new OPcode("SET 0,B", 2, 0, 4)}, {0xc1, new OPcode("SET 0,C", 2, 0, 4)},
              {0xc2, new OPcode("SET 0,D", 2, 0, 4)}, {0xc3, new OPcode("SET 0,E", 2, 0, 4)},
              {0xc4, new OPcode("SET 0,H", 2, 0, 4)}, {0xc5, new OPcode("SET 0,L", 2, 0, 4)},
              {0xc6, new OPcode("SET 0,(HL)", 2, 0, 4)}, {0xc7, new OPcode("SET 0,A", 2, 0, 4)},
              {0xc8, new OPcode("SET 1,B", 2, 0, 4)}, {0xc9, new OPcode("SET 1,C", 2, 0, 4)},
              {0xca, new OPcode("SET 1,D", 2, 0, 4)}, {0xcb, new OPcode("SET 1,E", 2, 0, 4)},
              {0xcc, new OPcode("SET 1,H", 2, 0, 4)}, {0xcd, new OPcode("SET 1,L", 2, 0, 4)},
              {0xce, new OPcode("SET 1,(HL)", 2, 0, 4)}, {0xcf, new OPcode("SET 1,A", 2, 0, 4)},
              {0xd0, new OPcode("SET 2,B", 2, 0, 4)}, {0xd1, new OPcode("SET 2,C", 2, 0, 4)},
              {0xd2, new OPcode("SET 2,D", 2, 0, 4)}, {0xd3, new OPcode("SET 2,E", 2, 0, 4)},
              {0xd4, new OPcode("SET 2,H", 2, 0, 4)}, {0xd5, new OPcode("SET 2,L", 2, 0, 4)},
              {0xd6, new OPcode("SET 2,(HL)", 2, 0, 4)}, {0xd7, new OPcode("SET 2,A", 2, 0, 4)},
              {0xd8, new OPcode("SET 3,B", 2, 0, 4)}, {0xd9, new OPcode("SET 3,C", 2, 0, 4)},
              {0xda, new OPcode("SET 3,D", 2, 0, 4)}, {0xdb, new OPcode("SET 3,E", 2, 0, 4)},
              {0xdc, new OPcode("SET 3,H", 2, 0, 4)}, {0xdd, new OPcode("SET 3,L", 2, 0, 4)},
              {0xde, new OPcode("SET 3,(HL)", 2, 0, 4)}, {0xdf, new OPcode("SET 3,A", 2, 0, 4)},
              {0xe0, new OPcode("SET 4,B", 2, 0, 4)}, {0xe1, new OPcode("SET 4,C", 2, 0, 4)},
              {0xe2, new OPcode("SET 4,D", 2, 0, 4)}, {0xe3, new OPcode("SET 4,E", 2, 0, 4)},
              {0xe4, new OPcode("SET 4,H", 2, 0, 4)}, {0xe5, new OPcode("SET 4,L", 2, 0, 4)},
              {0xe6, new OPcode("SET 4,(HL)", 2, 0, 4)}, {0xe7, new OPcode("SET 4,A", 2, 0, 4)},
              {0xe8, new OPcode("SET 5,B", 2, 0, 4)}, {0xe9, new OPcode("SET 5,C", 2, 0, 4)},
              {0xea, new OPcode("SET 5,D", 2, 0, 4)}, {0xeb, new OPcode("SET 5,E", 2, 0, 4)},
              {0xec, new OPcode("SET 5,H", 2, 0, 4)}, {0xed, new OPcode("SET 5,L", 2, 0, 4)},
              {0xee, new OPcode("SET 5,(HL)", 2, 0, 4)}, {0xef, new OPcode("SET 5,A", 2, 0, 4)},
              {0xf0, new OPcode("SET 6,B", 2, 0, 4)}, {0xf1, new OPcode("SET 6,C", 2, 0, 4)},
              {0xf2, new OPcode("SET 6,D", 2, 0, 4)}, {0xf3, new OPcode("SET 6,E", 2, 0, 4)},
              {0xf4, new OPcode("SET 6,H", 2, 0, 4)}, {0xf5, new OPcode("SET 6,L", 2, 0, 4)},
              {0xf6, new OPcode("SET 6,(HL)", 2, 0, 4)}, {0xf7, new OPcode("SET 6,A", 2, 0, 4)},
              {0xf8, new OPcode("SET 7,B", 2, 0, 4)}, {0xf9, new OPcode("SET 7,C", 2, 0, 4)},
              {0xfa, new OPcode("SET 7,D", 2, 0, 4)}, {0xfb, new OPcode("SET 7,E", 2, 0, 4)},
              {0xfc, new OPcode("SET 7,H", 2, 0, 4)}, {0xfd, new OPcode("SET 7,L", 2, 0, 4)},
              {0xfe, new OPcode("SET 7,(HL)", 2, 0, 4)}, {0xff, new OPcode("SET 7,A", 2, 0, 4)},
          };
       }
}