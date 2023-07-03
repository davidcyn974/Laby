<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/davidcyn974/Laby">
    <img src="images/Laby.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Laby</h3>

  <p align="center">
    Projet pour le cours 3DU1
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#A propos du projet">A propos du projet</a>
    </li>
    <li>
      <a href="#Comment commencer">Comment commencer</a>
    </li>
    <li><a href="#Utilisation">Utilisation</a></li>
    <li><a href="#Implémentation des différentes contraintes">Implémentation des différentes contraintes</a>
    <ul>
        <li><a href="#Contraintes principales">Contraintes principales</a></li>
        <li><a href="#Contraintes supplémentaires">Contraintes supplémentaires</a></li>
    </ul>
    </li>
    <li><a href="#Fonctionnalités supplémentaires">Fonctionnalités supplémentaires</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## A propos du projet
Pour ce projet, nous avons décidé de réaliser un jeu dans lequel le but est de rejoindre un cube vert en parcourant un labyrinthe.

<p align="right">(<a href="#readme-top">back to top</a>)</p>




<!-- GETTING STARTED -->
## Comment commencer

Pour lancer notre projet, il faut aller dans Assets/Scene et cliquer sur la scène qui a pour nom Menu. C'est le menu principal à partir duquel on peut commencer à jouer. Bien sur on peut aussi build le projet en allant sur "Build and run".
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- USAGE EXAMPLES -->
## Utilisation

Lorsque l'on appuie sur play, on arrive sur le menu principal. Dans le sous menu HELP nous avons indiqué comment jouer au jeu et finir la partie. Une fois que la partie est finie, on peut appuyer sur le bouton central et recommencer.
<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ROADMAP -->
## Implémentation des différentes contraintes

### Contraintes principales

Les 4 principales contraintes pour ce projet étaient: 
- [ ] Petit jeu en 3D
- [ ] Version 2021 de Unity
- [ ] Render Pipeline URP
- [ ] Avoir un player principal se déplaçant dans l'espace

Pour satisfaire ces contraintes, nous avons eu l'idée d'un jeu incluant une résolution de labyrinthe, ou nous prenons le contrôle d'un ballon de basket. On a ensuite converti le projet en URP.

### Contraintes supplémentaires

Voici comment nous avons implémenté les 7 autres contraintes supplémentaires:
- [ ] Système de lighting optimisé
<br>Nous avons changé la couleur de la lumière, pour faire une impression de lever de soleil. On a augmenté l'intensité aussi et changé la place.
- [ ] Un décor approprié, optimisé
<br>Nous avons cherché des matériaux relativement jolis pour constituer notre labyrinthe.
<br>Le terrain a été entièrement dessiné à la main.
<br>Le labyrinthe a été généré par <a href="https://mazegenerator.net/">mazegenerator.net</a>
- [ ] Des materials
<br>Nous en avons mis plusieurs, par exemple un material vert pour le cube d'arrivée.
<br>Certains 'materials' ont été importés comme pour les murs du labyrinthe, mais très peu.
- [ ] Shader
<br>Un shader graph a été appliqué sur le cube d'arrivée pour le faire "briller" avec une couleur orange.
- [ ] Particle System
<br>Nous avons mis des particules autour du ballon de basket et du cube.
- [ ] Physique
<br>Les murs du labyrinthe ne peuvent pas être traversés.
<br>Nous avons implémenté plusieurs plateformes qui affectent la physique.
<br>Une de saut (elle est en parquet en bois), une de vitesse.
- [ ] Coroutine
<br>La plateforme de vitesse change le matériel associé au joueur. Et le fait à la manière d'une animation dans le temps.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Fonctionnalités supplémentaires

Pour une meilleure expérience utilisateur, nous avons ajouté des menus. Le menu principal possède 3 boutons: 
<br> 
- Un bouton "QUIT" qui permet de quitter le jeu (si le projet est build)
- Un bouton "HELP" qui permet l'accès au deuxième menu qui explique les contrôles et le but du jeu
- Un bouton "PLAY" pour jouer au jeu.

<p align="right">(<a href="#readme-top">back to top</a>)</p>





<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/davidcyn974/Laby.svg?style=for-the-badge
[contributors-url]: https://github.com/davidcyn974/Laby/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/davidcyn974/Laby.svg?style=for-the-badge
[forks-url]: https://github.com/davidcyn974/Laby/network/members
[stars-shield]: https://img.shields.io/github/stars/davidcyn974/Laby.svg?style=for-the-badge
[stars-url]: https://github.com/davidcyn974/Laby/stargazers
[issues-shield]: https://img.shields.io/github/issues/davidcyn974/Laby.svg?style=for-the-badge
[issues-url]: https://github.com/davidcyn974/Laby/issues
[license-shield]: https://img.shields.io/github/license/davidcyn974/Laby.svg?style=for-the-badge
[license-url]: https://github.com/davidcyn974/Laby/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/linkedin_username
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
