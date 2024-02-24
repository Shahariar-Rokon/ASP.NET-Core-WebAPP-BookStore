# ASP.NET CORE MVC SPA - College BookStore


## Description

"Welcome to my dynamic ASP.NET Core MVC project! 
This application is a powerful demonstration of managing Master-Detail relationships using JavaScript and C#.

Imagine a platform where you can effortlessly:

- Record comprehensive student profiles: Store all the essential details about a student in a structured and accessible format.
- Manage diverse data types: This system is flexible enough to handle a wide array of data types, accommodating all the information you need to store.
- Experience seamless data submission: Leveraging the power of ASP.NET Core MVC Unobtrusive Ajax, data submission is smooth, efficient, and user-friendly.
- Handle master-detail relationships with ease: This application is designed to manage complex master-detail relationships, providing you with a clear and organized view of your data.

This project is a showcase of the robust capabilities of ASP.NET Core MVC and Unobtrusive Ajax. Dive in and explore the potential of efficient data management!"

## Installation
To install and run this project, follow these steps:

1. **Clone the repository**: Clone the repository to your local machine using the GitHub CLI command:

   ```shell
   gh repo clone Shahariar-Rokon/ASP.NET-Core-WebAPP-BookStore
   
Alternatively, you can download the ZIP file from the GitHub repository page: https://github.com/Shahariar-Rokon/ASP.NET-Core-WebAPP-BookStore.git
  
2. Open the project in Visual Studio 2022: Open Visual Studio 2022 and select “Open a project or solution”. Navigate to the folder where you cloned or downloaded the repository and select the .sln file.
3. Restore the NuGet packages: Right-click on the solution in the Solution Explorer and select “Restore NuGet Packages”. This will install the required dependencies for the project. Alternatively you can wait for the Visual Studio to auto restores the packages.
4. Update the database connection string: In the appsettings.json file, update the DefaultConnection value with your database connection string. Make sure the database server is running and accessible.
5. Apply the database migrations: In the Package Manager Console, run the following command to apply the code first migrations and create the database schema:
`Update-Database`
6. Run the project: Press F5 or click the “Run” button to launch the project in your browser.
   
## Usage

To use this project, follow these steps:

1. **Navigate to the app**: Open your browser and go to the URL where the app is hosted. For example, `https://localhost:44302/`.
2. **Interact with the app**: When running the app. You will be greated with a form. You can input the following data in the form
   - Student's Name
   - Student's Age
   - Buying Date
   - Student's Photo
     
After entering these data you will notice a button called **AddBook**. By pressing this button you can add

   - Book Title
   - Book Price
   Finally, click the **Add** buttton to submit the data. Note that, you have to add **Book Detail** to submit the form.
3. **Checking The result**: You can check your data entry by observing the table rows, located at the end of the form. From there you can also **Edit** and **Delete** the entry.
4. **Explore the code**: You can open the project in Visual Studio 2022 and explore the code. The project consists of javascript, jquery and C#.

## Contributing

We welcome contributions from anyone who is interested in improving this project. Here are some ways you can contribute:

- Report bugs or suggest features by opening an issue.
- Fix bugs or implement features by submitting a pull request.
- Review pull requests and provide feedback.
- Write or update documentation, tests, or examples.
- Share your experience or feedback with the project.

## License

This project is licensed under the MIT License. See the LICENSE file for details.
