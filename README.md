<a id="readme-top"></a>
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/TweenzY-Y/TapTrack">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">TapTrack</h3>

  <p align="center">
    Instantly add your currently playing song to your Spotify favorites with just one shortcut! My app makes it effortless for Spotify users to save their favorite tracks as they listen. No more missing out on that perfect song!
    <br />
    <!--<a href=""><strong>Explore the docs »</strong></a>-->
    <br />
    <br />
    <a href="https://github.com/TweenzY-Y/TapTrack/releases/download/Release/TapTrack.exe">Download EXE</a>
    ·
    <a href="https://github.com/TweenzY-Y/TapTrack/issues/new?labels=bug">Report Bug</a>
    ·
    <a href="https://github.com/TweenzY-Y/TapTrack/issues/new?labels=enhancement">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
    </li>
    <li>
      <a href="#setup">Setup</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#configuration-inside-the-application">Configuration inside the application</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

<!-- PRODUCT PHOTO IN THE FUTURE -->

My app is designed for Spotify enthusiasts who want a seamless way to add currently playing songs to their favorites. With just one shortcut, you can instantly save the tracks you love, ensuring you never lose track of your favorite tunes. This is especially useful when playing video games or studying and you don't want to be distracted.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- Setup -->
## Setup

Due to Spotify API authentication and authorization process, first contact with TapTrack might be not as intuitive as I wanted it to be. So I decided to make a detailed setup tutorial to make sure everyone will romp through this process. In the future I will try to automate it a little bit. 

### Prerequisites

* Before running TapTrack, you need to go to: https://developer.spotify.com/dashboard and click Create App button
* App name and app description is up to you.
* REQUIRED! In Redirect URIs field you have to put this:
  ```
  http://localhost:1337/callback/
  ```
* Check the "I understand and agree with Spotify's Developer Terms of Service and Design Guidelines" box and click "Save" button
* Now you should be redirected to the dashboard of the app you just created. If not, go here again: https://developer.spotify.com/dashboard and you should be able to find your app on the list. Click it.
* Click "Settings" button.
* Copy both "Client ID" and "Client secret" values or leave this page open, because you'll need it in a moment.

### Configuration inside the application

If you have "Client ID" and "Client secret" from Spotify Dev Dashboard you're ready to run TapTrack. If not, <a href="#prerequisites">go back to prerequisites section</a>

* As soon as you run TapTrack, you will see two fields where you have to enter "Client ID" and "Client secret" values. After that click "Submit"
* Click "Login through Spotify"
* After that, you will be redirected to a spotify website to give permission to your app. Click "Agree"
* After this step, you will be redirected again, this time to the localhost with information that this site can't be reached. Copy entire URL from address bar and paste it to TapTrack in "Redirect URI" field.
* Congrats! Now your TaskApp works. Press Shift+G to add currently playing track to your favorites!

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->
## Shortcut

 ```
  Shift+G
  ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

- [ ] Add "Run on startup" feature
- [ ] Add hiding whole app feature
- [ ] Automate setup process
- [ ] Add custom shortcuts

See the [open issues](https://github.com/TweenzY-Y/TapTrack/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors-anon/TweenzY-Y/TapTrack?style=for-the-badge
[contributors-url]: https://github.com/TweenzY-Y/TapTrack/graphs/contributors?style=for-the-badge
[forks-shield]: https://img.shields.io/github/forks/TweenzY-Y/TapTrack?style=for-the-badge
[forks-url]: https://github.com/TweenzY-Y/TapTrack/network/members?style=for-the-badge
[stars-shield]: https://img.shields.io/github/stars/TweenzY/TapTrack?style=for-the-badge
[stars-url]: https://github.com/TweenzY-Y/TapTrack/stargazers
[issues-shield]: https://img.shields.io/github/issues/TweenzY/TapTrack?style=for-the-badge
[issues-url]: https://github.com/TweenzY-Y/TapTrack/issues
