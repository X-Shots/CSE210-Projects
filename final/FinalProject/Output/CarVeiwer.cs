using System;
using System.Diagnostics;


public static class CarVeiwer{
     public static void ShowCarDetails(Car car)
    {
        Console.Clear();
        Console.WriteLine(car.getModel());

        try
        {
            // Open the image using the default image viewer
            Process.Start("open", car.getImagePath());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to open the image. Error: " + ex.Message);
        }
    }
    public static void veiwWithText(Car car){
        string htmlFilePath = "car_details.html";
        string htmlContent = $@"
        <html>
        <head>
            <title>{car.getMake()} {car.getModel()}</title>
            <style>
                body {{ font-family: Arial, sans-serif; margin: 20px; }}
                img {{ max-width: 100%; height: auto; }}
                .details {{ margin-top: 20px; }}
            </style>
        </head>
        <body>
            <h1>{car.getMake()} {car.getModel()} ({car.getModelYear()} - {car.getType()})</h1>
            <img src='{car.getImagePath()}' alt='Car Image' />
            <div class='details'>
                {car.getHTMLDetails()}
                
            </div>
        </body>
        </html>";

        // Write the HTML to a file
        File.WriteAllText(htmlFilePath, htmlContent);

        try
        {
            Process.Start("open", htmlFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to open the HTML file. Error: " + ex.Message);
        }
    }

}