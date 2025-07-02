
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgChartsModule } from 'ng2-charts';
import { BarChartComponent } from './component/bar-chart/bar-chart.component';

@NgModule({
  declarations: [BarChartComponent],
  imports: [CommonModule, NgChartsModule],
  exports: [BarChartComponent]
})
export class SharedModule {}
