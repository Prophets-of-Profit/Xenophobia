if (typeof kotlin === 'undefined') {
  throw new Error("Error loading module 'Xenophobia'. Its dependency 'kotlin' was not found. Please, check whether 'kotlin' is loaded prior to 'Xenophobia'.");
}
var Xenophobia = function (_, Kotlin) {
  'use strict';
  var println = Kotlin.kotlin.io.println_s8jyv4$;
  function main(args) {
    println('Hello world!');
  }
  _.main_kand9s$ = main;
  main([]);
  Kotlin.defineModule('Xenophobia', _);
  return _;
}(typeof Xenophobia === 'undefined' ? {} : Xenophobia, kotlin);
