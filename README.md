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


## AI Usage
While AI tools were used to tidy up documentation and comments, the core problem-solving and implementation are my own.


**-AI Tool Used** - Microsoft Copilot


**- AI Prompt**


Write a short, clear README.md for my C# Old Phone Pad project. The project decodes old phone keypad input into text. Describe what each class does (DefaultKeypadLayout, OldPhonePadDecoder, and test project) and keep the README simple.



You can see the exact AI prompt used <a href="https://copilot.microsoft.com/shares/Jni5DptMp8BPyEaizT2yT">here</a>.
