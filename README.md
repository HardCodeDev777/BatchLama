# 💻🦙 BatchLama

## 🚀 Overview

**BatchLama** allows you to communicate with LLMs locally via Ollama in Batch! Example:

```bat
BatchLama.exe "deepseek-r1:7b, Your answer mustn't be more then 50 words, When GitHub was created"
```

##  ⌨️ Syntax

Put model name first, then system prompt and then your prompt.

> [!IMPORTANT]
> NEVER, I said NEVER use "," cuz this is how in C# code(source) works:
> ```csharp
> var input = args[0];
> var words = input.Split(',');
> try
> {
>   _modelName = words[0];
>   _systemPrompt = words[1];
>   _userPrompt = words[2];
> }
> catch
> {
>   Console.WriteLine("Incorrect syntax or amount of arguments!");
>   return;
> }
> ```

## 📄 License

This project is licensed under the **MIT License**.  
See LICENSE for full terms.

---

## 👨‍💻 Author

**HardCodeDev**  
- [GitHub](https://github.com/HardCodeDev777)  
- [Itch.io](https://hardcodedev.itch.io/)

---

> 💬 Got feedback, found a bug, or want to contribute? Open an issue or fork the repo on GitHub!
