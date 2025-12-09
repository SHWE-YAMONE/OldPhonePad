using Xunit;
using OldPhonePad;

namespace OldPhonePad.Tests;

// Unit tests for OldPhonePadDecoder
public class OldPhonePadDecoderTests
{
    // Test case 1: Basic input
    [Fact]
    public void TestCase1()
    {
        var result = OldPhonePadDecoder.OldPhonePad("33#");
        Assert.Equal("E", result);
    }

    // Test case 2: Input with multiple presses
    [Fact]
    public void TestCase2()
    {
        var result = OldPhonePadDecoder.OldPhonePad("227*#");
        Assert.Equal("B", result);
    }

    // Test case 3: Input with spaces
    [Fact]
    public void TestCase3()
    {
        var result = OldPhonePadDecoder.OldPhonePad("4433555 555666#");
        Assert.Equal("HELLO", result);
    }

    // Test case 4: Input with mixed keys
    [Fact]
    public void TestCase4()
    {
        var result = OldPhonePadDecoder.OldPhonePad("8 88777444666*664#");
        Assert.Equal("TURING", result);
    }

    // Test case 5: Null input
    [Fact]
    public void TestCase5()
    {
        Assert.Throws<ArgumentNullException>(() =>
            OldPhonePadDecoder.OldPhonePad(null!)
        );
    }

    // Test case 6: Missing end key
    [Fact]
    public void TestCase6()
    {
        var ex = Assert.Throws<ArgumentException>(() =>
            OldPhonePadDecoder.OldPhonePad("22")
        );

        Assert.Equal("Missing '#' end key.", ex.Message);
    }

    // Test case 7: Invalid character in input
    [Fact]
    public void TestCase7()
    {
        var ex = Assert.Throws<ArgumentException>(() =>
            OldPhonePadDecoder.OldPhonePad("22A#")
        );

        Assert.Equal("Only digits, space, '*' and '#' are allowed", ex.Message);
    }

}
