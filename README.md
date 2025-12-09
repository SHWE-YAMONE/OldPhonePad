# Old Phone Pad

Decodes old phone keypad input into readable text
For Example:
> "4433555 555666#" -> HELLO

"#" means SEND in this text

## How it works
**- DefaultKeypadLayout**

Maps digits (`0–9`) to their characters (e.g. `2` → `"ABC"`, `0` → `" "`).


**- OldPhonePadDecoder**

Contains the static method:
>public static string OldPhonePad(string input)



**- OldPhonePadDecoderTests**

Contains the test cases 




## How to Run
```
cd OldPhonePad.Tests
dotnet test
```
