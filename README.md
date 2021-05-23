# Dependency Injection in ASP.Net Core
This project source consists the dependency Injection example

* Dependency Injection is software design pattern technique which is used to achieve the Inversion Of Control(IoC) between classes and their dependencies.

* As a good developer we should write the logic or code which should be loosely coupled not tightly coupled, it makes easy to maintain the code.

* Main benifit of the Dependency Injection is , it helps us to manage future changes and other complexity in our software.

## Source Code Explaination
Below is the folder structure

![image](https://user-images.githubusercontent.com/81896060/119248390-78c7dd80-bbae-11eb-9fe9-82a100725985.png)


* Create the Folder and create the class file Product.cs

![image](https://user-images.githubusercontent.com/81896060/119250835-65257280-bbc0-11eb-98a3-78eac904c970.png)

* Create the folder interfaces and add the file IProducts.cs

![image](https://user-images.githubusercontent.com/81896060/119250891-c6e5dc80-bbc0-11eb-9660-fabefd946bc6.png)

* Next Create the folder Services and add the file called ProductService.cs

![image](https://user-images.githubusercontent.com/81896060/119250964-57242180-bbc1-11eb-8be7-e5b23e8c20d9.png)

### ASP.Net core comes with default dependency injection feature. we need to inform who is the implementor for IProducts.cs interface.

### Lets add below code in Startup.cs

![image](https://user-images.githubusercontent.com/81896060/119251029-ce59b580-bbc1-11eb-98ea-bf01f635c706.png)

* Create controller and call the detail and List method using constructor injection( Create the interface variable)

![image](https://user-images.githubusercontent.com/81896060/119251129-6fe10700-bbc2-11eb-9ea4-c92819cf8e1e.png)

> Main benifit of the dependency injection is if you want to change the implementor(ProductService to MyProductService), only one place you can change the i.e. Startup.cs
