using System.Text;
using OldPhonePad.Layouts;

namespace OldPhonePad;

// Decodes old phone keypad input into readable text
public static class OldPhonePadDecoder
{
    private static readonly DefaultKeypadLayout Layout = new();

    // Converts a sequence of keypad presses into text
    public static string OldPhonePad(string input)
    {
        // Validate input
        if (input == null)
            throw new ArgumentNullException(nameof(input));

        // Find the end key '#'
        int end = input.IndexOf('#');
        if (end < 0)
            throw new ArgumentException("Missing '#' end key.");

        // Process input up to the end key
        string seq = input[..end];
        var output = new StringBuilder();

        // Current key being processed
        char? current = null;
        int presses = 0;

        // Turns the current key presses into a letter
        void Commit()
        {

            if (current == null || presses == 0) return;

            // Get letters for the current key
            string? letters = Layout.GetCharactersForKey(current.Value);
            if (letters != null)
                output.Append(letters[(presses - 1) % letters.Length]);

            // Reset current key state
            current = null;
            presses = 0;
        }

        foreach (char c in seq)
        {
            // Only allow digits, space, '*' or '#'
            if (!(char.IsDigit(c) || c == '*' || c == '#' || c == ' '))
            {
                throw new ArgumentException(
                    $"Only digits, space, '*' and '#' are allowed");
            }

            switch (c)
            {
                case ' ':
                    // Finish the current letter
                    Commit();
                    break;

                case '*':
                    // Backspace functionality
                    if (presses > 0)
                    {
                        // Remove current key presses
                        current = null;
                        presses = 0;
                    }
                    else if (output.Length > 0)
                    {
                        // Delete last letter from output
                        output.Length--;
                    }
                    break;

                default:
                    if (char.IsDigit(c))
                    {
                        // Same key pressed again
                        if (current == c)
                            presses++;
                        else
                        {
                            // Different key pressed, commit previous letter
                            Commit();
                            current = c;
                            presses = 1;
                        }
                    }
                    else
                    {
                        // Any other symbol ends current letter
                        Commit();
                    }
                    break;
            }
        }

        // Commit any remaining key presses
        Commit();
        return output.ToString();
    }
}