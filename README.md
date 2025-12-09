# Old Phone Pad Decoder

This C# project simulates decoding text input from an old mobile phone keypad (like T9-style typing).  
It converts sequences of numeric key presses into readable text.
For Example:
> "4433555 555666#" -> HELLO

"#" means SEND in this text

## Project Structure
**- DefaultKeypadLayout**

Maps digits (`0–9`) to their characters (e.g. `2` → `"ABC"`, `0` → `" "`).


**- OldPhonePadDecoder**

Handles the logic for decoding sequences of key presses into text.
Contains the static method:
>public static string OldPhonePad(string input)



**- OldPhonePadDecoderTests**

Contains the test cases to verify the correctness of the keypad layout and decoder logic.




## How to Run
```
cd OldPhonePad.Tests
dotnet test
```
