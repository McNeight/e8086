﻿
namespace KDS.e8086
{
    public class i8086Table
    {
        public static OpCodeTable[] opCodes = new OpCodeTable[]
        {
            new OpCodeTable(0x00,"add {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x01,"add {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x02,"add {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x03,"add {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x04,"add {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0x05,"add {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0x06,"push es",0,"ES","","",""),
            new OpCodeTable(0x07,"pop es",0,"ES","","",""),
            new OpCodeTable(0x08,"or {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x09,"or {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x0A,"or {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x0B,"or {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x0C,"or {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0x0D,"or {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0x0E,"push cs",0,"CS","","",""),
            new OpCodeTable(0x0F,"pop cs",0,"CS","","",""),
            new OpCodeTable(0x10,"adc {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x11,"adc {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x12,"adc {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x13,"adc {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x14,"adc {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0x15,"adc {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0x16,"push ss",0,"SS","","",""),
            new OpCodeTable(0x17,"pop ss",0,"SS","","",""),
            new OpCodeTable(0x18,"sbb {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x19,"sbb {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x1A,"sbb {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x1B,"sbb {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x1C,"sbb {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0x1D,"sbb {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0x1E,"push ds",0,"DS","","",""),
            new OpCodeTable(0x1F,"pop ds",0,"DS","","",""),
            new OpCodeTable(0x20,"and {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x21,"and {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x22,"and {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x23,"and {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x24,"and {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0x25,"and {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0x26,"es:",0,"","","",""),
            new OpCodeTable(0x27,"daa",0,"","","",""),
            new OpCodeTable(0x28,"sub {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x29,"sub {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x2A,"sub {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x2B,"sub {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x2C,"sub {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0x2D,"sub {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0x2E,"cs:",0,"","","",""),
            new OpCodeTable(0x2F,"das",0,"","","",""),
            new OpCodeTable(0x30,"xor {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x31,"xor {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x32,"xor {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x33,"xor {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x34,"xor {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0x35,"xor {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0x36,"ss:",0,"","","",""),
            new OpCodeTable(0x37,"aaa",0,"","","",""),
            new OpCodeTable(0x38,"cmp {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x39,"cmp {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x3A,"cmp {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x3B,"cmp {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x3C,"cmp {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0x3D,"cmp {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0x3E,"ds:",0,"","","",""),
            new OpCodeTable(0x3F,"aas",0,"","","",""),
            new OpCodeTable(0x40,"inc ax",0,"AX","","",""),
            new OpCodeTable(0x41,"inc cx",0,"CX","","",""),
            new OpCodeTable(0x42,"inc dx",0,"DX","","",""),
            new OpCodeTable(0x43,"inc bx",0,"BX","","",""),
            new OpCodeTable(0x44,"inc sp",0,"SP","","",""),
            new OpCodeTable(0x45,"inc bp",0,"BP","","",""),
            new OpCodeTable(0x46,"inc si",0,"SI","","",""),
            new OpCodeTable(0x47,"inc di",0,"DI","","",""),
            new OpCodeTable(0x48,"dec ax",0,"AX","","",""),
            new OpCodeTable(0x49,"dec cx",0,"CX","","",""),
            new OpCodeTable(0x4A,"dec dx",0,"DX","","",""),
            new OpCodeTable(0x4B,"dec bx",0,"BX","","",""),
            new OpCodeTable(0x4C,"dec sp",0,"SP","","",""),
            new OpCodeTable(0x4D,"dec bp",0,"BP","","",""),
            new OpCodeTable(0x4E,"dec si",0,"SI","","",""),
            new OpCodeTable(0x4F,"dec di",0,"DI","","",""),
            new OpCodeTable(0x50,"push ax",0,"AX","","",""),
            new OpCodeTable(0x51,"push cx",0,"CX","","",""),
            new OpCodeTable(0x52,"push dx",0,"DX","","",""),
            new OpCodeTable(0x53,"push bx",0,"BX","","",""),
            new OpCodeTable(0x54,"push sp",0,"SP","","",""),
            new OpCodeTable(0x55,"push bp",0,"BP","","",""),
            new OpCodeTable(0x56,"push si",0,"SI","","",""),
            new OpCodeTable(0x57,"push di",0,"DI","","",""),
            new OpCodeTable(0x58,"pop ax",0,"AX","","",""),
            new OpCodeTable(0x59,"pop cx",0,"CX","","",""),
            new OpCodeTable(0x5A,"pop dx",0,"DX","","",""),
            new OpCodeTable(0x5B,"pop bx",0,"BX","","",""),
            new OpCodeTable(0x5C,"pop sp",0,"SP","","",""),
            new OpCodeTable(0x5D,"pop bp",0,"BP","","",""),
            new OpCodeTable(0x5E,"pop si",0,"SI","","",""),
            new OpCodeTable(0x5F,"pop di",0,"DI","","",""),
            new OpCodeTable(0x60,"mov {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x61,"mov {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x62,"mov {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x63,"mov {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x64,"mov {0},{1}",2,"R/M","w","S","w"),
            new OpCodeTable(0x65,"lea {0},{1}",2,"REG","v","M",""),
            new OpCodeTable(0x66,"mov {0},{1}",2,"S","w","R/M","w"),
            new OpCodeTable(0x67,"pop {0}",1,"R/M","v","",""),
            new OpCodeTable(0x68,"",-1,"","","",""),
            new OpCodeTable(0x69,"",-1,"","","",""),
            new OpCodeTable(0x6A,"",-1,"","","",""),
            new OpCodeTable(0x6B,"",-1,"","","",""),
            new OpCodeTable(0x6C,"",-1,"","","",""),
            new OpCodeTable(0x6D,"",-1,"","","",""),
            new OpCodeTable(0x6E,"",-1,"","","",""),
            new OpCodeTable(0x6F,"",-1,"","","",""),
            new OpCodeTable(0x70,"jo {0}",1,"J","b","",""),
            new OpCodeTable(0x71,"jno {0}",1,"J","b","",""),
            new OpCodeTable(0x72,"jb {0}",1,"J","b","",""),
            new OpCodeTable(0x73,"jnb {0}",1,"J","b","",""),
            new OpCodeTable(0x74,"jz {0}",1,"J","b","",""),
            new OpCodeTable(0x75,"jnz {0}",1,"J","b","",""),
            new OpCodeTable(0x76,"jbe {0}",1,"J","b","",""),
            new OpCodeTable(0x77,"ja {0}",1,"J","b","",""),
            new OpCodeTable(0x78,"js {0}",1,"J","b","",""),
            new OpCodeTable(0x79,"jns {0}",1,"J","b","",""),
            new OpCodeTable(0x7A,"jpe {0}",1,"J","b","",""),
            new OpCodeTable(0x7B,"jpo {0}",1,"J","b","",""),
            new OpCodeTable(0x7C,"jl {0}",1,"J","b","",""),
            new OpCodeTable(0x7D,"jge {0}",1,"J","b","",""),
            new OpCodeTable(0x7E,"jle {0}",1,"J","b","",""),
            new OpCodeTable(0x7F,"jge {0}",1,"J","b","",""),
            new OpCodeTable(0x80,"",-1,"R/M","b","I","b"),
            new OpCodeTable(0x81,"",-1,"R/M","v","I","v"),
            new OpCodeTable(0x82,"",-1,"R/M","b","I","b"),
            new OpCodeTable(0x83,"",-1,"R/M","v","I","b"),
            new OpCodeTable(0x84,"test {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x85,"test {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x86,"xchg {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x87,"xchg {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x88,"mov {0},{1}",2,"R/M","b","REG","b"),
            new OpCodeTable(0x89,"mov {0},{1}",2,"R/M","v","REG","v"),
            new OpCodeTable(0x8A,"mov {0},{1}",2,"REG","b","R/M","b"),
            new OpCodeTable(0x8B,"mov {0},{1}",2,"REG","v","R/M","v"),
            new OpCodeTable(0x8C,"mov {0},{1}",2,"R/M","w","S","w"),
            new OpCodeTable(0x8D,"lea {0},{1}",2,"REG","v","M",""),
            new OpCodeTable(0x8E,"mov {0},{1}",2,"S","w","R/M","w"),
            new OpCodeTable(0x8F,"pop {0}",1,"R/M","v","",""),
            new OpCodeTable(0x90,"",0,"","","",""),
            new OpCodeTable(0x91,"xchg cx,ax",0,"CX","AX","",""),
            new OpCodeTable(0x92,"xchg dx,ax",0,"DX","AX","",""),
            new OpCodeTable(0x93,"xchg bx,ax",0,"BX","AX","",""),
            new OpCodeTable(0x94,"xchg sp,ax",0,"SP","AX","",""),
            new OpCodeTable(0x95,"xchg bp,ax",0,"BP","AX","",""),
            new OpCodeTable(0x96,"xchg si,ax",0,"SI","AX","",""),
            new OpCodeTable(0x97,"xchg di,ax",0,"DI","AX","",""),
            new OpCodeTable(0x98,"cbw",0,"","","",""),
            new OpCodeTable(0x99,"cwd",0,"","","",""),
            new OpCodeTable(0x9A,"call {0}",1,"A","p","",""),
            new OpCodeTable(0x9B,"wait",0,"","","",""),
            new OpCodeTable(0x9C,"pushf",0,"","","",""),
            new OpCodeTable(0x9D,"popf",0,"","","",""),
            new OpCodeTable(0x9E,"sahf",0,"","","",""),
            new OpCodeTable(0x9F,"lahf",0,"","","",""),
            new OpCodeTable(0xA0,"mov {0},{1}",2,"AL","","O","b"),
            new OpCodeTable(0xA1,"mov {0},{1}",2,"AX","","O","v"),
            new OpCodeTable(0xA2,"mov {0},{1}",2,"O","b","AL",""),
            new OpCodeTable(0xA3,"mov {0},{1}",2,"O","v","AX",""),
            new OpCodeTable(0xA4,"movsb",0,"","","",""),
            new OpCodeTable(0xA5,"movsw",0,"","","",""),
            new OpCodeTable(0xA6,"cmpsb",0,"","","",""),
            new OpCodeTable(0xA7,"cmpsw",0,"","","",""),
            new OpCodeTable(0xA8,"test {0},{1}",2,"AL","","I","b"),
            new OpCodeTable(0xA9,"test {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0xAA,"stosb",0,"","","",""),
            new OpCodeTable(0xAB,"stosw",0,"","","",""),
            new OpCodeTable(0xAC,"lodsb",0,"","","",""),
            new OpCodeTable(0xAD,"lodsw",0,"","","",""),
            new OpCodeTable(0xAE,"scasb",0,"","","",""),
            new OpCodeTable(0xAF,"scasw",0,"","","",""),
            new OpCodeTable(0xB0,"mov {0},{1}",2,"AL","","I","v"),
            new OpCodeTable(0xB1,"mov {0},{1}",2,"CL","","I","v"),
            new OpCodeTable(0xB2,"mov {0},{1}",2,"DL","","I","v"),
            new OpCodeTable(0xB3,"mov {0},{1}",2,"BL","","I","v"),
            new OpCodeTable(0xB4,"mov {0},{1}",2,"AH","","I","v"),
            new OpCodeTable(0xB5,"mov {0},{1}",2,"CH","","I","v"),
            new OpCodeTable(0xB6,"mov {0},{1}",2,"DH","","I","v"),
            new OpCodeTable(0xB7,"mov {0},{1}",2,"BH","","I","v"),
            new OpCodeTable(0xB8,"mov {0},{1}",2,"AX","","I","v"),
            new OpCodeTable(0xB9,"mov {0},{1}",2,"CX","","I","v"),
            new OpCodeTable(0xBA,"mov {0},{1}",2,"DX","","I","v"),
            new OpCodeTable(0xBB,"mov {0},{1}",2,"BX","","I","v"),
            new OpCodeTable(0xBC,"mov {0},{1}",2,"SP","","I","v"),
            new OpCodeTable(0xBD,"mov {0},{1}",2,"BP","","I","v"),
            new OpCodeTable(0xBE,"mov {0},{1}",2,"SI","","I","v"),
            new OpCodeTable(0xBF,"mov {0},{1}",2,"DI","","I","v"),
            new OpCodeTable(0xC0,"",-1,"","","",""),
            new OpCodeTable(0xC1,"",-1,"","","",""),
            new OpCodeTable(0xC2,"reg {0}",1,"I","w","",""),
            new OpCodeTable(0xC3,"ret",0,"","","",""),
            new OpCodeTable(0xC4,"les {0},{1}",2,"REG","v","M","p"),
            new OpCodeTable(0xC5,"lds {0},{1}",2,"REG","v","M","p"),
            new OpCodeTable(0xC6,"mov {0},{1}",2,"R/M","b","I","b"),
            new OpCodeTable(0xC7,"mov {0},{1}",2,"R/M","v","I","v"),
            new OpCodeTable(0xC8,"",-1,"","","",""),
            new OpCodeTable(0xC9,"",-1,"","","",""),
            new OpCodeTable(0xCA,"retf {0}",1,"I","w","",""),
            new OpCodeTable(0xCB,"retf {0}",0,"","","",""),
            new OpCodeTable(0xCC,"int 3",0,"3","","",""),
            new OpCodeTable(0xCD,"int {0}",1,"I","b","",""),
            new OpCodeTable(0xCE,"into",0,"","","",""),
            new OpCodeTable(0xCF,"iret",0,"","","",""),
            new OpCodeTable(0xD0,"",-1,"R/M","b","1",""),
            new OpCodeTable(0xD1,"",-1,"R/M","v","1",""),
            new OpCodeTable(0xD2,"",-1,"R/M","b","CL",""),
            new OpCodeTable(0xD3,"",-1,"R/M","v","CL",""),
            new OpCodeTable(0xD4,"aam {0}",1,"I","0","",""),
            new OpCodeTable(0xD5,"aad {0}",1,"I","0","",""),
            new OpCodeTable(0xD6,"",-1,"","","",""),
            new OpCodeTable(0xD7,"xlat",0,"","","",""),
            new OpCodeTable(0xD8,"",-1,"","","",""),
            new OpCodeTable(0xD9,"",-1,"","","",""),
            new OpCodeTable(0xDA,"",-1,"","","",""),
            new OpCodeTable(0xDB,"",-1,"","","",""),
            new OpCodeTable(0xDC,"",-1,"","","",""),
            new OpCodeTable(0xDD,"",-1,"","","",""),
            new OpCodeTable(0xDE,"",-1,"","","",""),
            new OpCodeTable(0xDF,"",-1,"","","",""),
            new OpCodeTable(0xE0,"loopnz {0}",1,"J","b","",""),
            new OpCodeTable(0xE1,"loopz {0}",1,"J","b","",""),
            new OpCodeTable(0xE2,"loop {0}",1,"J","b","",""),
            new OpCodeTable(0xE3,"jcxz {0}",1,"J","b","",""),
            new OpCodeTable(0xE4,"in al",0,"AL","","",""),
            new OpCodeTable(0xE5,"in ax",0,"AX","","",""),
            new OpCodeTable(0xE6,"out {0},{1}",2,"I","b","AL",""),
            new OpCodeTable(0xE7,"out {0},{1}",2,"I","b","AX",""),
            new OpCodeTable(0xE8,"call {0}",1,"J","v","",""),
            new OpCodeTable(0xE9,"jmp {0}",1,"J","v","",""),
            new OpCodeTable(0xEA,"jmp {0}",1,"A","p","",""),
            new OpCodeTable(0xEB,"jmp {0}",1,"J","b","",""),
            new OpCodeTable(0xEC,"in al,dx",0,"AL","","DX",""),
            new OpCodeTable(0xED,"in ax,dx",0,"AX","","DX",""),
            new OpCodeTable(0xEE,"out dx,al",0,"DX","","AL",""),
            new OpCodeTable(0xEF,"out dx,ax",0,"DX","","AX",""),
            new OpCodeTable(0xF0,"lock",0,"","","",""),
            new OpCodeTable(0xF1,"",-1,"","","",""),
            new OpCodeTable(0xF2,"repnx",0,"","","",""),
            new OpCodeTable(0xF3,"repz",0,"","","",""),
            new OpCodeTable(0xF4,"hlt",0,"","","",""),
            new OpCodeTable(0xF5,"cmc",0,"","","",""),
            new OpCodeTable(0xF6,"",-1,"R/M","b","",""),
            new OpCodeTable(0xF7,"",-1,"R/M","v","",""),
            new OpCodeTable(0xF8,"clc",0,"","","",""),
            new OpCodeTable(0xF9,"stc",0,"","","",""),
            new OpCodeTable(0xFA,"cli",0,"","","",""),
            new OpCodeTable(0xFB,"sti",0,"","","",""),
            new OpCodeTable(0xFC,"cld",0,"","","",""),
            new OpCodeTable(0xFD,"std",0,"","","",""),
            new OpCodeTable(0xFE,"",-1,"R/M","b","",""),
            new OpCodeTable(0xFF,"",-1,"R/M","v","","")

        };
    }
}