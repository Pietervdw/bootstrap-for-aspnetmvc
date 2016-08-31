var gulp = require('gulp');
var gulpSass = require('gulp-sass');

gulp.task('default', function () { console.log('Running Gulp') });

gulp.task('compile-sass', function () {
    gulp.src('./bower_components/bootstrap/scss/bootstrap.scss')
        .pipe(gulpSass())
        .pipe(gulp.dest('./wwwroot/css'));
});
