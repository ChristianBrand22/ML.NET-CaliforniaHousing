Informations an dataset from Mark Farraghers Course "Introduction to Machine Learning in C#"

Train the Model

mlnet regression --dataset .\california_housing_train.csv --test-dataset .\california_housing_test.csv --label-col median_house_value --ignore-cols housing_median_age total_rooms total_bedrooms population households median_income

Run the test 
Copy the MLModel.zip File from 
CaliforniaHousing\SampleRegression\SampleRegression.Model
to
CaliforniaHousing\SampleRegression\

Console
Go with cd to \SampleRegression\SampleRegression.ConsoleApp or \SampleRegression and the put in the following comand in the console and hit enter:

dotnet run --project SampleRegression.ConsoleApp


----------------------------------------------------------------------



    --dataset: the dataset to use for training the machine learning model. This can be a comma-separated or tab-separated text file.
    --validation-dataset: the dataset to use to validate the performance of the fully-trained machine learning model.
    --label-col: the column in the dataset that contains the label we're trying to predict.
    --ignore-cols: an optional list of columns in the dataset to ignore.

So what we're doing here is trying to predict the median_house_value column. We're ignoring every other column in the dataset except latitude and longitude.

There are three folders:

    SampleRegression: The solution folder for the generated app containing a single SLN file for Visual Studio.
    SampleRegression/SampleRegression.ConsoleApp: A console project that consumes the fully-trained model to make a prediction. There's also a ModelBuilder.cs file which can train the model from scratch.
    SampleRegression/SampleRegression.Model: A library project with helper classes for training and consuming the model. There's also a ZIP file with a saved copy of the fully-trained model which can be consumed right away without any further training.

You can use these project files as the basis for your own machine learning application. Out of the box, these files will replicate the best performance you saw when running the ML.NET CLI tool.

At this point, you have two possible scenarios for building your own app:

    Load the ZIP file with the fully-trained model and start making predictions right away. You'll need to link the SampleRegression.Model project into your own solution, and then use the code in SampleRegression.ConsoleApp/Program.cs as a starting point to consume the model.
    Train your own model from scratch. You'll need to link the SampleRegression.Model project into your own solution, and then use the code in SampleRegression.ConsoleApp/ModelBuilder.cs as a starting point to train your model. You'll also need to put the CSV training files in your project directory.

The first scenario is fine if your training data is static and not expected to change. Just load the ZIP file with the pretrained model and start making predictions right away.

The second scenario is useful if your training data is very dynamic and changes all the time, necessitating constant retraining. Grab the latest data, train your model from scratch and then start making predictions based on the most recent data.