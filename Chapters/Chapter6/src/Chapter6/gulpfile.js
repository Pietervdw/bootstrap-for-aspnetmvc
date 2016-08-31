/// <binding BeforeBuild='compile-sass' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var gulpSass = require('gulp-sass');

gulp.task('compile-sass', function () {
    gulp.src('./wwwroot/lib/bootstrap/scss/bootstrap.scss')
        .pipe(gulpSass())
        .pipe(gulp.dest('./wwwroot/css'));
});
