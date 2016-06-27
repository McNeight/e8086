﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KDS.e8086;

namespace e8086UnitTests
{
    /// <summary>
    /// Summary description for ExecutionUnitTests
    /// </summary>
    [TestClass]
    public class ExecutionUnitTests
    {
        public ExecutionUnitTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        private i8086CPU GetCPU(byte[] program)
        {
            i8086CPU cpu = new i8086CPU();
            cpu.Boot(program);
            cpu.EU.Bus.DS = 0x2000;
            cpu.EU.Bus.SS = 0x4000;
            cpu.EU.Bus.ES = 0x6000;
            return cpu;
        }

        [TestMethod]
        public void Test88()
        {
            byte value8;

            i8086CPU cpu = GetCPU(new byte[] { 0x88, 0x4f, 0x10 } /* MOV [bx+10],CL */);
            value8 = 0x2f;

            cpu.EU.Registers.CL = value8;
            cpu.NextInstruction();

            Assert.AreEqual(value8, cpu.EU.Bus.GetData8(cpu.EU.Registers.BX + 0x10), "Instruction 0x88 failed");

            cpu.Boot(new byte[] { 0x88, 0x8f, 0x10, 0x00 } /* MOV [bx+10],CL using 16 bit displacement */);
            value8 = 0x2f;

            cpu.EU.Registers.CL = value8;
            cpu.NextInstruction();

            Assert.AreEqual(value8, cpu.EU.Bus.GetData8(cpu.EU.Registers.BX + 0x10), "Instruction 0x88 failed");

        }

        [TestMethod]
        public void Test89()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0x89, 0xd8, 0x10 } /* MOV ax,bx */);

            cpu.EU.Registers.AX = 0x11ab;
            cpu.EU.Registers.BX = 0x22fe;
            cpu.NextInstruction();

            Assert.AreEqual(0x22fe, cpu.EU.Registers.AX, "Instruction 0x89 failed");
        }

        [TestMethod]
        public void Test8a()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0x8a, 0x4f, 0x10 } /* MOV CL, [BX+10] */);
            byte value8 = 0x2f;

            cpu.EU.Registers.BX = 0x10ff;
            cpu.EU.Registers.CL = 0xff;
            cpu.EU.Bus.SaveData8(cpu.EU.Registers.BX + 0x10, value8);
            cpu.NextInstruction();

            Assert.AreEqual(value8, cpu.EU.Registers.CL, "Instruction 0x8a failed");

            // test the use of the base pointer
            cpu = GetCPU(new byte[] { 0x8a, 0x4e, 0x10 } /* MOV CL, [BP+10] */);

            cpu.EU.Registers.BP = 0x10ff;
            cpu.EU.Registers.CL = 0xff;
            cpu.EU.Bus.UsingBasePointer = true;
            cpu.EU.Bus.SaveData8(cpu.EU.Registers.BP + 0x10, value8);
            cpu.NextInstruction();

            Assert.AreEqual(value8, cpu.EU.Registers.CL, "Instruction 0x8a failed (2)");
            Assert.AreEqual(false, cpu.EU.Bus.UsingBasePointer, "Instruction 0x8a failed (3)");

        }

        [TestMethod]
        public void Test8b()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0x8b, 0xc8 } /* MOV cx,ax (16 bit) */);

            cpu.EU.Registers.AX = 0x11ab;
            cpu.EU.Registers.CX = 0x22fe;
            cpu.NextInstruction();

            Assert.AreEqual(0x11ab, cpu.EU.Registers.CX, "Instruction 0x8b failed");
        }

        [TestMethod]
        public void Test8c()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0x8c, 0x5f, 0x35 } /* MOV bx+35, ds (16 bit) */);

            cpu.EU.Bus.DS = 0x76d2;
            cpu.EU.Registers.BX = 0x1015;

            cpu.NextInstruction();

            Assert.AreEqual(0x76d2, cpu.EU.Bus.GetData16(cpu.EU.Registers.BX + 0x35), "Instruction 0x8c failed");
        }

        [TestMethod]
        public void Test8e()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0x8e, 0x45, 0x35 } /* MOV es, di+35 (16 bit) */);

            cpu.EU.Bus.ES = 0xffff;
            cpu.EU.Registers.DI = 0x1015;
            cpu.EU.Bus.SaveData16(cpu.EU.Registers.DI + 0x35, 0x9f23);

            cpu.NextInstruction();

            Assert.AreEqual(0x9f23, cpu.EU.Bus.ES, "Instruction 0x8e failed");
        }

        [TestMethod]
        public void Testa0()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0xa0, 0x23, 0x98 });
            cpu.EU.Bus.SaveData8(0x9823, 0x65);
            cpu.NextInstruction();

            Assert.AreEqual(0x65, cpu.EU.Registers.AL, "Instruction a0 failed");
        }

        [TestMethod]
        public void Testa1()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0xa1, 0x23, 0x98 });
            cpu.EU.Bus.SaveData16(0x9823, 0x65fe);
            cpu.NextInstruction();

            Assert.AreEqual(0x65fe, cpu.EU.Registers.AX, "Instruction a1 failed");
        }

        [TestMethod]
        public void Testa2()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0xa2, 0x23, 0x98 });
            cpu.EU.Registers.AL = 0xc4;
            cpu.NextInstruction();

            Assert.AreEqual(0xc4, cpu.EU.Bus.GetData8(0x9823), "Instruction a2 failed");
        }

        [TestMethod]
        public void Testa3()
        {
            i8086CPU cpu = GetCPU(new byte[] { 0xa3, 0x23, 0x98 });
            cpu.EU.Registers.AX = 0xc42f;
            cpu.NextInstruction();

            Assert.AreEqual(0xc42f, cpu.EU.Bus.GetData16(0x9823), "Instruction a3 failed");
        }

        [TestMethod]
        public void Testc6()
        {
            // MOV [100],28
            i8086CPU cpu = GetCPU(new byte[] { 0xc6, 0x06, 0x00, 0x01, 0x28 });
            cpu.NextInstruction();

            Assert.AreEqual(0x28, cpu.EU.Bus.GetData8(0x100), "Instruction c6 failed");

            // MOV [si],39
            cpu = GetCPU(new byte[] { 0xc6, 0x04, 0x39 });

            cpu.EU.Registers.SI = 0x350;
            cpu.NextInstruction();

            Assert.AreEqual(0x39, cpu.EU.Bus.GetData8(cpu.EU.Registers.SI), "Instruction c6 failed (2)");
        }

        [TestMethod]
        public void Testc7()
        {
            // MOV [100],28fa
            i8086CPU cpu = GetCPU(new byte[] { 0xc7, 0x06, 0x00, 0x01, 0xfa, 0x28 });
            cpu.NextInstruction();

            Assert.AreEqual(0x28fa, cpu.EU.Bus.GetData16(0x100), "Instruction c7 failed");

            // MOV [si],3902
            cpu = GetCPU(new byte[] { 0xc7, 0x04, 0x02, 0x39 });

            cpu.EU.Registers.SI = 0x350;
            cpu.NextInstruction();

            Assert.AreEqual(0x3902, cpu.EU.Bus.GetData16(cpu.EU.Registers.SI), "Instruction c7 failed (2)");
        }
    }
}