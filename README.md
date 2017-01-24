# Azure Precompiled Function
This repository contains a sample for a Azure Precompiled Function

Installation can manual can be found on:

- [Creating your first Precompiled Azure Function](https://msftplayground.com/2017/01/creating-your-first-precompiled-azure-function)

## Installation

- Open the Azure Portal [https://portal.azure.com](https://portal.azure.com)
- Navigate to the resource group where in you want to create the Function or create a new one.
- In the resource group click “Add” to create a “Function App”.

![alt text](https://i2.wp.com/msftplayground.com/wp-content/uploads/2017/01/image-9.png?ssl=1 "Create Function App")

- In the created Function App create a new function. In this example a C# Manually triggered function will be created.

![alt text](https://i2.wp.com/msftplayground.com/wp-content/uploads/2017/01/image-10.png?ssl=1 "Create Function")

- In the develop section of the function click on “View files”.

![alt text](https://i2.wp.com/msftplayground.com/wp-content/uploads/2017/01/image-11.png?ssl=1 "View Files")

- In the file browser delete the “run.csx” file and adjust the “function.json” file as mentioned above.
- Now use the upload button to upload the compiled file.
- Click the “Run” button so see if your compiled function works.

![alt text](https://i2.wp.com/msftplayground.com/wp-content/uploads/2017/01/image-12.png?ssl=1 "View Files")

The functionality looks very promising and make sure you bypass the dynamic compilation process. But there are a few things to keep in mind when the Azure Function:

- When you make manual adjustments within the portal the function.json file will be refreshed (both scriptFile and entryPoint properties will be removed).
- Compiled files will only be loaded the first time you run the function. When you make changes to the compiled file you will need to restart the function app before changes will be applied.
