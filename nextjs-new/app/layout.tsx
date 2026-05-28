import type { Metadata } from "next";
import "./globals.css";

export const metadata: Metadata = {
  title: "Menmen's Golden House",
  description: "A personal Golden House rebuilt with Next.js and ASP.NET Core.",
};

export default function RootLayout({ children }: Readonly<{ children: React.ReactNode }>) {
  return (
    <html lang="en">
      <body>{children}</body>
    </html>
  );
}
