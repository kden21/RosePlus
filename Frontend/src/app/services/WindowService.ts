import {Injectable} from "@angular/core";
import {WindowSize} from "../enums/WindowSize";

@Injectable()
export class WindowService {
  public windowSize = WindowSize.lg;
  public windowSizePx = 1000;

  changeWindowSize (size: number) {
    this.windowSizePx = size;

    if (size >= 1600)
      this.windowSize = WindowSize.xxl;
    else if (size >= 1200)
      this.windowSize = WindowSize.xl
    else if (size >= 992)
      this.windowSize = WindowSize.lg;
    else if (size >= 768)
      this.windowSize = WindowSize.md;
    else if (size >= 576)
      this.windowSize = WindowSize.sm;
    else
      this.windowSize = WindowSize.xs;
  }
}
