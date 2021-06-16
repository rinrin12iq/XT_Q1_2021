function removeChar()
{
    let str1 = document.getElementById("input").value;
    const SEPARATORS = [" ", ":", ";", ",", ".", "\t", "?", "!"];
    let someObjects = {}; 
    let str2;

    str1.split(' ').forEach(function (word) {
        word.split('').forEach(function (letter, i) {
            if (!someObjects[letter] && SEPARATORS.indexOf(letter) == -1 && word.indexOf(letter, i + 1) != -1) {
                someObjects[letter] = 1;
            }
        });
    });

    str2 = str1.split('').filter( i => !someObjects[i] ).join('');

    document.getElementById("output").value = str2;
}
