# Simple quadratic equation solver with interactive and non-interactive mode
># How to build and run:
>>## Windows:
>>- ```winget install Microsoft.DotNet.Runtime.6``` in cmd or download [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
>>- Clone this repository
>>- Open cmd in ```lab1_SDMT\QuadraticEqSolver\QuadraticEqSolver```
>>- Run or build with ```dotnet run``` ```dotnet build```
>>- If you want to run in non-interactive mode simply add source to your .txt file with certain data
>>## Linux:
>>- Install .NET runtime (example for Debian, for other distros check [here](https://learn.microsoft.com/en-us/dotnet/core/install/linux?WT.mc_id=dotnet-35129-website)) \
>>```wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb``` \
>>```sudo dpkg -i packages-microsoft-prod.deb``` \
>>```rm packages-microsoft-prod.deb``` \
>>``sudo apt-get update && \
  sudo apt-get install -y dotnet-runtime-6.0``
>>- Clone this repository
>>- Open terminal in ```lab1_SDMT/QuadraticEqSolver/QuadraticEqSolver```
>>- Run or build with ```dotnet run``` ```dotnet build```
>>- If you want to run in non-interactive mode simply add source to your .txt file with certain data

>## Note: 
- Non-interactive mode supports only ```.txt``` files, also there is the test file in this repo.
- Data in file should simply look like ```12 13 -15``` which define ```a b c``` respectively

>## Revert commit [link](https://github.com/ImLewel/lab1_SDMT/commit/1880e959cd19b5ecd8b45429d77f11fd77a4bb3f)
