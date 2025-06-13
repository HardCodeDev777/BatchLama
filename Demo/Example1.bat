@echo off

echo 1. For example, you want to use "deepseek-r1:7b" model, your system prompt is "Your answer mustn't be more then 50 words" and your prompt is "When GitHub was created" - you need to write this in your .bat file this:
echo BatchLama.exe "deepseek-r1:7b, Your answer mustn't be more then 50 words, When GitHub was created"
echo 2. Then put your .bat file and BatchLama.exe in the same directory.
echo 3. Run Ollama and then your .bat

echo Btw this is AI response from prompt:
BatchLama.exe "deepseek-r1:7b, Your answer mustn't be more then 50 words, When GitHub was created"

pause
