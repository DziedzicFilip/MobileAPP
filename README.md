# MobileAPP – SeenIT

**MobileAPP (SeenIT)** is a mobile application written in C#, designed for the Android platform (with the possibility of expansion to iOS and UWP). The project serves to manage a list of watched movies, add your own reviews and ratings, and catalogue your movie collection.

## Description

The application allows users to:
- Create and manage their own list of watched movies.
- Add reviews and ratings to movies.
- Browse the history of watched titles.
- Store the database locally (see `BazaDanych.sql` file).
- Synchronize data in the future, thanks to integration with a custom API (`MobileApp/RestApiSeenit`).

The application is aimed at movie enthusiasts who want to easily track their viewing history and share their opinions about watched productions.

## Technologies

- **Programming language:** C#
- **Platform:** Xamarin / .NET (Android, iOS, UWP)
- **Database:** SQL (`BazaDanych.sql` file)
- **Architecture:** The project contains separate directories for Android, iOS, UWP, and the business logic layer

## Project Structure

```
MobileAPP/
│
├── BazaDanych.sql                # SQL database structure
├── MobileApp/                    # Main application folder
│   ├── MobileApp.sln             # Visual Studio solution
│   ├── RestApiSeenit/            # (API backend – under development)
│   └── SeenIT/                   # Application source code
│       ├── SeenIT.Android/       # Android version
│       ├── SeenIT.iOS/           # iOS version
│       ├── SeenIT.UWP/           # Windows version
│       └── SeenIT/               # Business logic and models
```

## Installation and Running

1. Clone the repository:
   ```bash
   git clone https://github.com/DziedzicFilip/MobileAPP.git
   ```
2. Open the `MobileApp.sln` file in Visual Studio (a version supporting Xamarin is recommended).
3. Prepare the database according to the `BazaDanych.sql` file.
4. Set up the target project (Android/iOS/UWP).
5. Run the application on the selected emulator or physical device.

## Features

- Add new movies to the list
- Edit and delete entries
- Write your own reviews and ratings
- Browse viewing history
- (Planned) Synchronization with a custom API

## Contribution

Suggestions and pull requests are welcome! Please report issues via the Issues tab.

## License

This project is available under the MIT license.

---

**Author:** Filip Dziedzic  
Repository: [DziedzicFilip/MobileAPP](https://github.com/DziedzicFilip/MobileAPP)
