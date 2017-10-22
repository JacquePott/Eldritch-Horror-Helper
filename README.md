# Eldritch Horror Helper
Companion app for Eldritch Horror board game to handle card management.



INSTRUCTIONS FOR USE
--------------------
Setup
-----
Divide your Eldritch Horror investigator possession cards (the small ones like Assets, Conditions, etc.) by type and then alphabetise them. Start the Eldritch Horror Helper app. Select all of the expansions you're using by double-clicking each entry in the list and click the Start New Game button.

Drawing Cards
-----
Select a card type from the dropdown menu. Then, optionally, follow these steps:
  * To get an Asset of a specific cost, enter the number from 1-4 in the Cost field. Other values will be ignored and the field isn't used for other card types.
  * Filter by card tags (the block capital, bolded, and italicised text like TRINKET or RITUAL) with the tags field. An empty field will be ignored.
    * For example, use 'ITEM' to get only cards of your chosen type with the ITEM tag.
    * If you enter multiple tags like 'TRINKET MAGICAL' to get only items with both tags.
    * You can use parentheses to use any of the tags within the parentheses. EG: '(ITEM TRINKET)' will get only ITEMs and TRINKETs.
    * Parentheses can be combined with non-parenthesised tags. This allows you to do '(ITEM TRINKET) MAGICAL RELIC' to get any cards with ITEM MAGICAL RELIC or TRINKET MAGICAL RELIC.

Click on 'Draw Card' when you've set up the filters to get a new card. The name, type, tags, and for Assets the cost will be displayed. The chances of any card appearing are weighted appropriately by what expansions are in use. When multiple cards have the same name (like multiple Debt Conditions for example) select one of them from the deck at random.

If you cannot gain the card (for example it is a Spell or Condition the drawing player already has or an Asset that was taken when choosing investigators) then click the 'Redraw Card' button. This will get a new card with the same filters that you haven't seen since first hitting the Draw button.

When you've got the card you want, if it is a single-sided card (Asset or Artifact) then click 'Keep Card'. This will remove it from the pool for future draws. If you don't mind the extra upkeep, you can also do this for double-sided cards to keep the probabilities of drawing them 100% accurate.

Managing Removed Cards
-----
Click on the Removed Cards tab to view what cards have been removed by using the 'Keep Card' button.

Here you can use the 'Shuffle In Removed' button to put all of the removed cards back in the virtual deck.

You can more selectively choose which cards to put back in by selecting a number of rows by clicking the grey, leftmost column of the table. You can hold Ctrl to select more after the first. Then click 'Shuffle In Selected' to put those cards in the deck.
