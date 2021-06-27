![seDirector logo](https://sedirector.net/assets/images/logo.jpg)

# 1. Translations

seDirector is a game server administration program for the Steam Source Engine.
See seDirector.net for more information.

## 1.1. Languages Needing Translation

If you can read & write in any of these languages, we'd love your help translating seDirector.

-   Chinese
-   ~~Traditional Chinese~~ thank you [in2002-tw](https://github.com/in2002-tw)
-   French
-   German
-   Hindi
-   Italian
-   Japanese
-   Korean
-   Russian
-   Spanish
-   Tagalog
-   Portuguese

## 1.2. Getting Started

1.  Sign into GitHub if you aren't already signed in
2.  Fork this repo
3.  Create a copy of `English.json` and name it `LanguageName.json` (i.e. `Klingon.json`)
4.  Edit the language file that corresponds with your age by going to your forked copy and then clicking the little pen icon at the bottom right of the page)
5.  Alternatively, you can create a clone of the fork locally through GitHub desktop then push your changes back to the origin when finished
6.  Come back to this repo and make a new pull request
7.  One of us will check out the translation and approve it once we confirm the translation with another party
8.  If approved, your username will be mentioned in seDirector as a contributor!
9.  Make sure to change the comments section at the top of the language file

A good JSON editor to use is http://jsoneditoronline.org.

### 1.2.1. Rules to Follow

1.  Do not translate if you don't read and write the language
2.  If you see HTML tags in the English version, do NOT change/remove the HTML tags, just replace words/phrases as needed
3.  Keep the case the same - if it's capitalized, capitalize the translation; if there is a period, use a period in the translation, if it has a comma, use commas, etc.
4.  Use single-quotes in-place of double-quotes, ' instead of ", or escape double quotes in JSON with a backslash such as \"
5.  There will be duplicate lines - keep them
6.  When you see a number in braces, that is a tag that means a variable will go there. Keep the `{0}` or `{1}` tags in the translation. As long as it makes the same sense as the English version, you can move them as needed.
7.  `{LB}` means line break - please keep existing line breaks and double line breaks
8.  If you are unsure of a translation, have a friend help you out before you create a pull request

## 1.3. Have A Question or Concern

Open an [Issue](https://github.com/seDirector/Translations/issues) and someone will address it.

## 1.4. seDirector Support

Please join our [Discord channel](https://sedirector.net/discord) or e-mail us via our website at seDirector.net.
