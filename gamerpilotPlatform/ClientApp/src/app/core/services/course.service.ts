import { Injectable, Inject, OnInit, OnDestroy } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Feedback } from '../../../models/feedback';

@Injectable({
  providedIn: 'root'
})
export class CourseService implements OnDestroy {
  baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') _baseUrl: string) {
    this.baseUrl = _baseUrl + 'api/courses/';
  }


  getCourse(name: string) {
    return this.http
    .get(this.baseUrl + name);
  }

  getCourses() {
    return this.http
    .get(this.baseUrl);
  }

  getUserCourse(name: string) {
    return this.http
    .get(this.baseUrl + `user/${name}`);
  }

  enroll(name: string) {
    return this.http
    .post(this.baseUrl + `enroll`, {urlName: name});
  }

  saveFeedback(feedback: Feedback) {
    return this.http
    .post(this.baseUrl + `feedback`, feedback);
  }



  ngOnDestroy() {

  }
}