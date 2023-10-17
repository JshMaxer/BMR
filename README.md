# BEBU’S MOVIE RECOMMENDATION
![8-anWV14FKHc9ht1p](https://github.com/JshMaxer/BMR/assets/78284063/b4a068a0-dd49-4a12-a717-903ecdc88b23)

## Overview

The Movie Recommendation App is a Windows Forms application built using C# that provides users with a daily movie recommendation based on the current day and month's genre. The application leverages the TMDb (The Movie Database) API to fetch movie data, including titles, overviews, ratings, and posters.

## Features

- **Dynamic Movie Recommendation:** The app dynamically fetches the top-rated movie for the current day based on the genre associated with the current month.

- **Genre Selection:** Each month is associated with a specific genre, ensuring that the recommended movie aligns with the month's theme.

- **User Interface:** The app offers a user-friendly interface with a movie title, overview, rating, genre, and poster display.

## Prerequisites

- Before running the application, you need to obtain an API key from TMDb. Right click and click **TMBB API** and paste your actual TMDb API key for the app to fetch data successfully.
- To exit the application, Right click and click **BEBU's MOVIE RECOMMENDATION APP** then click **EXIT**.


```csharp
private const string ApiKey = "YOUR_TMDB_API_KEY";
```

## Month of the genre's

**January (Month 1): Adventure**

**February (Month 2): Romance**

**March (Month 3): Drama**

**April (Month 4): Comedy**

**May (Month 5): War**

**June (Month 6): Crime**

**July (Month 7): Fantasy**

**August (Month 8): History**

**September (Month 9): Action**

**October (Month 10): Sci-Fi**

**November (Month 11): Horror**

**December (Month 12): Animation**

## Dependencies
Newtonsoft.Json: A popular JSON framework for .NET used to parse JSON data received from the TMDb API.

## Credits
TMDb API: The app utilizes the TMDb API to fetch movie data. Visit [TMDb website](https://www.themoviedb.org/documentation/api) for API documentation and usage guidelines.

## Concept of the BMR
[BMR Concept](https://github.com/JshMaxer/BMR/files/12903063/BMR.Concept.pdf)

