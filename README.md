
# Divinity Original Sin 4 Player Patch

A simple patcher for playing with up to 4 players for the game *Divinitiy: Original Sin*.
The game and engine were built to support up to 4 players but for whatever reason
they don't make it possible without modifying a few files literally changing a "2" to
a "4" in various places to increase the limit from 2 to 4 players.

## What versions are supported?

* 2.0.119.430
* 2.0.113.775
* 2.0.104.737
* 2.0.100.40
* 2.0.99.676
* 2.0.99.113

## What does this tool do?

As mentioned the changes needed are absurdly small and well known by the community. This patcher
includes all the small (10 byte) strings and their replacements for applying and removing
the 4 player patch.

The original list of byte sequences was found from:
  https://steamcommunity.com/sharedfiles/filedetails/?id=548760493

## Does it work for the GoG version of Divinity: Original Sin?

Yes.

## Does it work for the Steam version?

It should but you have to pick the EXE manually and Steam might automatically patch it back. I need
someone with Steam to test this.

## Can I apply official patches afterwards?

Yes before running the patch you may wish to "restore" to original depending on
how future game patches are released.

## Can I patch "vanilla" Divinity: Original Sin without Enhanced Edition?

The vanilla version only needs the EXE changed and won't need the .LSX files. Someone needs to test this.

## Is this compatible with other mods?

It should be since it has to be done outside the traditional modding system in the game.

## Why is this not a mod / pak file?

Because it has to modify the EXE itself and mods are only allowed to modify data files.
