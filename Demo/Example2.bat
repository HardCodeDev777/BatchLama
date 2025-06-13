@echo off
setlocal enabledelayedexpansion

echo Don't use ,

set /p model_name="Model name: "
set /p system_prompt="System prompt: "
set /p user_prompt="Your prompt: "

BatchLama.exe "!model_name!,!system_prompt!,!user_prompt!"
pause
