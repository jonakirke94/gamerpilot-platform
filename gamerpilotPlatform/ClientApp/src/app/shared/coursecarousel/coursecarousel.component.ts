import { Component, OnInit, Output, Input, EventEmitter, OnDestroy } from '@angular/core';
import { CourseService } from '../../core/services/course.service';
import { Subscription } from 'rxjs';

declare var $: any;

@Component({
  selector: 'app-coursecarousel',
  templateUrl: './coursecarousel.component.html',
  styleUrls: ['./coursecarousel.component.scss']
})
export class CourseCarouselComponent implements OnInit, OnDestroy {
  @Input()  course: any;
  @Output() viewcourse = new EventEmitter<string>();
  courses: any = [];
  $courses: Subscription;
  carouselItems: any = [];
  isDataLoaded = false;
  constructor(private _courseService: CourseService) { }

     ngOnInit() {
      this.fetchCourses();


      $('#carouselExample').on('slide.bs.carousel', function (e) {
        const $e = $(e.relatedTarget);
        const idx = $e.index();
        const itemsPerSlide = 4;
        const totalItems = $('.carousel-item').length;
        if (idx >= totalItems - (itemsPerSlide - 1)) {
          const it = itemsPerSlide - (totalItems - idx);
            for (let i = 0; i < it; i++) {
                if (e.direction === 'left') {
                    $('.carousel-item').eq(i).appendTo('.carousel-inner');
                } else {
                    $('.carousel-item').eq(0).appendTo('.carousel-inner');
                }
            }
        }
      });
      $('#carouselExample').carousel( {
                interval: 2000,
            });
    }

    ngOnDestroy() {
        this.$courses.unsubscribe();
    }

    fetchCourses() {
      this.$courses = this._courseService.getCourses().subscribe(res => {
        this.courses = res['data'];
        this.courses.push(res['data'][0]);
        this.courses.push(res['data'][0]);
        this.courses.push(res['data'][0]);

        this.isDataLoaded = true;
        console.log(this.courses);
        console.log(this.courses[0]);
      });



    }

  }
