# Repro Steps
- `cd ./my-appshell` and run `npm i` and then `npm run build`
- `cd ../my-pilet` and run `dotnet build`
- `cd ../piral~/my-pilet` and run `npm start`

# Problem
When you click `Shop` in the top right you will be redirected to `/shop`.
Here you can add Items to the cart. 
The items appear in the cart list and the count in the card (marked green) gets updated.
The problem is that the count in pages and extensions (marked red) does not get updated.
StateHasChanged() is automatically called when an item gets updated, but i have also added buttons whicjt call StateHasChanged() again manually.

It Seems like StateHasChanged has no effect in pages and extensions.