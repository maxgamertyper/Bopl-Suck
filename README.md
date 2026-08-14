# Bopl-Suck (tsuG)
A bopl mod that changes the gust ability so that it's reversed and instead sucks items in (tsuG is Gust backwards)

*Allows for player state copying and customizations when 'munching' another player*

## Quick Links
* **[MyBoplMods Repo](https://github.com/maxgamertyper/MyBoplMods)**
* **[Demonstration Video](https://youtu.be/d0EHBE6xT9I)**
* **[Direct Video Download](https://github.com/maxgamertyper/Bopl-Suck/edit/main/suckmod.mp4)**
* **[Thunderstore Link](https://thunderstore.io/c/bopl-battle/p/maxgamertyper1/tsuG/)**


---


## General Information & Setup

### Mod-Manager Setup
>* This is specifically guided for Thunderstore; it may be slightly different for other mod managers.*

#### Prerequisites
* A mod manager (Thunderstore, R2ModMan, or others) configured for the game Bopl Battle
* The game Bopl Battle

#### Steps

1) access the **Bopl Battle** game
2) Make a new mod profile
3) go to the mods tab
4) Search for "tsuG"
5) Click Download
6) Run the game twice (it won't work the first time, as the manager is initializing the mod installer)
7) Have fun


### BepInEx Setup
>* Note: this is directed towards a Windows installation*

#### Prerequisites
* An installation of the BepInEx ZIP file
* The game Bopl Battle
* the Suck.dll file

#### Steps
1) Find your game directory through Steam, likely at `C:\Program Files (x86)\Steam\steamapps\common\Bopl Battle`
2) Unzip the BepInEx file into the folder
3) Run the game once
4) return to the directory
5) Move the Suck.dll file into the plugins folder
6) Run the game
7) Have fun

---

## Configuration Architecture

**This mod has no configuration as it's a very simple reversal of a value**
  * **Take Color:** This toggles whether the "consumer" will take the color of the "consumed" when eaten *and applicable by the absolute config*
  * **Take Size:** This toggles whether the "consumer" will take the size of the "consumed" when eaten *and applicable by the absolute config*
