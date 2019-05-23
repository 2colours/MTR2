using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MTR2.Dal.SeedInterfaces;
using MTR2.Dal.Entities;

namespace MTR2.Dal.SeedService
{
	public class SeedService : ISeedService
	{
		public IList<RepoArticle> RepoArticles { get; } = new[] {
new RepoArticle() {
				  Id=1,
				Order=1,
Content=@"## The Alphabet
---

The best place to start with learning any language is the alphabet. With 14 vowels and 30 consonants,
the Hungarian alphabet contains a total of 44 letters. Hungarian is a phonetic language so once you master the alphabet, you'll be able to speak
every word that you can read first time every time! Note that every word in Hungarian is stressed on the first syllable.

```
A Á B C Cs D Dz Dzs E É F
a á b c cs d dz dzs e é f

G Gy H I Í J K L Ly M N
g gy h i í j k l ly m n

Ny O Ó Ö Ő P Q R S Sz T 
ny o ó ö ő p q r s sz t  

Ty U Ú Ü Ű V W X Y Z Zs
ty u ú ü ű v w x y z zs
```
Some of the letters consist of more than one character. These are called digraphs if there are two characters creating the sound, or trigraphs if there are three (There is just one trigraph in Hungarian - dzs). They are treated as distinct letters in the Hungarian language, and have their own specific sounds.

It should be noted that the Hungarian language has **gemination**, or consonant lengthening.
Consonants can be paired together for a longer consonant sound. 

* Legsze**bb** - (Most beautiful)
* U**jj** - (Finger)
* Á**ll** - (Stand)
* Kö**nny** - (Tear (long ny))
* Sebe**ss**ég - (Speed)
* A**ssz**ony - (Mrs. (long sz))

See how only the first letter of a digraph is lengthened. For example, instead of `szsz` we write `ssz`.

When some consonants are combined, the pronunciation changes slightly to become more natural. Try to recognise the base words to see which consonants are really there.

* Igazság (Igaz - true) becomes [Iga*ss*ág]
* Állj meg! (Áll - stand) becomes [Á*jj* meg!]
* Egészség (Egész - whole) becomes [Egé*ss*ég] 
* Ne haragudj! (Haragszik - he/she is angry) becomes [Ne haragu*ggy*!]

### Videos to help pronunciation

* [Pronouncing Sounds (No Spelling)](https://www.youtube.com/watch?v=tjSQ3E1zSxo)
* [Spelling the Letters](https://www.youtube.com/watch?v=Wll1C4_JVCo)
* [Both + Vocab](https://www.youtube.com/watch?v=UusKeY47FPc)

## Vowel Harmony
---

Grammarwise, Hungarian solves all their problems with prefixes and suffixes. The vowels these attachments use depends on vowel harmony. 

The vowels in Hungarian are paired. The second row marks elongation on the vowels (and a change in sound for á and é).
```
a e i o ö u ü
á é í ó ő ú ű
```

For vowel harmony, these vowels are sorted as either front or back (Hungarians refer to these as deep or high). Here are some non-sensical sentences to remember each.

```
Front: e é i í ö ő ü ű (Öt üveg-űző épít itt.)
Back:  a á o ó u ú     (A Zuzmó-Háború.)
```

* If a word contains only front vowels, then it should be conjugated with front vowels. `épület`
* Likewise, if a word contains only back vowels, then it should be conjugated with back vowels. `darázs`
* If a word contains a mixture of front and back, the last vowel will specify what kind it is. `dzsungel`

If the word is only one-syllable *and* contains only `i` or `í` then it can be considered back-vowelled or front-vowelled. E.g.

* `szív` - ((the noun) considered front-vowelled word)
* `híd` - (considered back-vowelled word)

That's it for now. Check out [wikipedia's article on pronunciation](https://en.wiktionary.org/wiki/Appendix:Hungarian_pronunciation_assimilation) for more information.
",
Title="ABC + Vowel Harmony"
},
new RepoArticle {
Id=2,
Order=2,
Content=@"## Phrases & Words
---

Now that you've mastered pronunciation, here are some basic phrases and words to get you started! Be aware that everything here is simplified and not much is explained, but if you keep coming back to here, everything will start to click.

| Magyar                                             | English                       |
|----------------------------------------------------|-------------------------------|
| Jó reggelt (kívánok)                               | Good morning                  |
| Jó napot  (kívánok)                                | Good day                      |
| Jó estét  (kívánok)                                | Good evening                  |
| Jó éjszakát                                        | Good night                    |
| Jó étvágyat                                        | Bon Appetit                   |
| Szép napot                                         | Have a nice day               |
| Neked is* (to one person)                          | to you as well                |
| Nektek is* (to many)                               | to you as well                |
| Helló/Szia/Szevasz (to one person)                 | Hi/Hey/Bye                    |
| Helló/Sziasztok/Szevasztok (to many)               | Hi/Hey/Bye                    |
| Viszlát/Viszontlátásra                             | Goodbye                       |
| Hogy vagy? (to one person)                         | How are you?                  |
| Hogy vagytok? (to many)                            | How are you?                  |
| Igen                                               | Yes                           |
| Nem                                                | No/Not                        |
| Talán                                              | Maybe                         |
| (Nem) tudom                                        | I (don't) know                |
| (Nem) értem                                        | I (don't) understand          |
| Köszönöm/köszi (szépen)                            | Thank you (very much)         |
| Szívesen                                           | You're welcome                |
| Nincs mit                                          | Don't mention it              |
| Kérem                                              | Please                        |
| Bocsánat                                           | Sorry                         |
| Elnézést                                           | Excuse me                     |
| Mennyibe kerül ez?                                 | How much is this?             |
| Hol van a mosdó?                                   | Where is the toilet?          |
| Hány óra van? / Mennyi az idő?                     | What's the time?              |
| Segítség!                                          | Help!                         |
| Tűz! / Tűz van!                                    | Fire! / There's a fire!       |
| Beszélsz angolul?                                  | Do you speak English?         |
| Igen, csak egy kicsit*                             | Yes, only a little             | 
| Ez                                                 | This                          |
| Az                                                 | That                          |
| És                                                 | And                           |
| Ma                                                 | Today                         |
| Holnap                                             | Tomorrow                      |
| Tegnap                                             | Yesterday                     |


* `Neked/nektek is` are responses to thoses phrases beginning with `jó` or `szép`.
* `Igen, csak egy kicsit` is a reponse to `beszélsz angolul/magyarul?`

`Challenge!`
![bomba](https://magyartanulas.github.io/public/bomba.png)

*- Hát, ez nem jó! (Free image fetched from ardiafm.com)*

---

\### Yet to Learn

Naturally because phrases have been introduced, the list will be long, but eventually these will all be covered.

* `-t` marks the [accusative](https://magyartanulas.github.io/accusative_plurals/)
* `-nak,-nek` which marks the [dative case](https://magyartanulas.github.io/dative_possession/)
* `hány,mennyi` used for [counting](https://magyartanulas.github.io/counting/)
* `ez, az` are [pronouns](https://magyartanulas.github.io/pronouns/) were mentioned
* The use of `nem` and `nincs` for [negation](https://magyartanulas.github.io/negation/)
* The use of `-be` which is a [locative](https://magyartanulas.github.io/locatives/)

",
Title="Phrases"
 }
		}.ToList<RepoArticle>();

		public IList<BlogArticle> BlogArticles { get; } = new[] {
new BlogArticle() {
				  AuthorId=1,
Content=@"
## Big Demo article...
",
CreationDate=DateTime.Now,
Id=1,
Title="Welcome all!",
ShortDescription="Ehn order to put it on screen easily :D"
},
new BlogArticle() {
				  AuthorId=2,
Content=@"
## Big Demo article...

__asd___asd_
a
*a**a**
eh
",
CreationDate=DateTime.Now,
Id=2,
Title="Another post here",
ShortDescription="In order to put it on screen easily :D"
}
		};
	}
}
